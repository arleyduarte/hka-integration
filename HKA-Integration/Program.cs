using log4net;
using System;
using System.Configuration;
using System.IO;

namespace Timbrar_TXT_XMLPDF
{
    class Program
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {

            log4net.Config.BasicConfigurator.Configure();
            log.Info("Inicio " + System.DateTime.Now.ToLongTimeString());

            String successFolder = "\\Aprobados\\"; 



            var input = ConfigurationManager.AppSettings.Get("Input"); //Ruta de la carpeta de entrada
            var output =  ConfigurationManager.AppSettings.Get("Output"); //Ruta de la carpeta de salida
            var usuario = ConfigurationManager.AppSettings.Get("User"); //Se lee el atributo usuario desde el archivo de configración
            var contrasena = ConfigurationManager.AppSettings.Get("Password"); //Se lee el atributo contraseña desde el archivo de configración


            if (!Directory.Exists(output))
            {
                Directory.CreateDirectory(output);
            }

            if (!Directory.Exists(input))
            {
                Directory.CreateDirectory(input);
            }



            if (!Directory.Exists(output + "\\Error"))
            {
                Directory.CreateDirectory(output + "\\Error");
            }



                        

            string[] files = Directory.GetFiles(input);
            string[] filePaths = Directory.GetFiles(input);
            for (int i = 0; i < filePaths.Length; i++)
            {
                files[i] = Path.GetFileName(filePaths[i]);
            }


            WsColombia.ResponseTimbre respuesta = new WsColombia.ResponseTimbre();
            String fileToProcess = "";
            for (int i=0; i< files.Length;i++) {
                try
                {

                    fileToProcess = input + files[i];


                    byte[] array = File.ReadAllBytes(fileToProcess);

                    log.Error(String.Format("Procesando el archivo: {0}", fileToProcess));

                    WsColombia.Main cl = new WsColombia.Main();

                    respuesta = cl.TimbreEnviaTXT32(usuario, contrasena, array, files[i]);

                    if (respuesta.Codigo == 100)
                    {
                        File.Move(input + files[i], output + successFolder + files[i]);
                        log.Info("Codigo: " + respuesta.Codigo + " Mensaje: " + respuesta.Mensaje);
  
                    }
                    else
                    {
                        log.Error(String.Format("Ocurrio un error al procesesar el archivo: {0}, error: {1}", fileToProcess, respuesta.Mensaje));
                        File.Move(input + files[i], output + "\\Error\\" + files[i]);


                    }
                }
                catch (Exception e)
                {
                    

                    String exception = e.Message;
                    if (String.IsNullOrWhiteSpace(exception))
                    {
                        exception = "error en el servidor";
                    }
                    log.Error(String.Format("Ocurrio un error al procesesar el archivo: {0}, error: {1}", fileToProcess, exception));

                    File.Move(input + files[i], output + "\\Error\\" + files[i]);
                }
                finally
                {
                    log.Info("FIN " + System.DateTime.Now.ToLongTimeString());
                }

            }
                         
        }

    }
 

}
