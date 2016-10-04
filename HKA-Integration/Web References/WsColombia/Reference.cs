﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Timbrar_TXT_XMLPDF.WsColombia {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IMain", Namespace="http://tempuri.org/")]
    public partial class Main : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback TimbreEnviaTXT32OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Main() {
            this.Url = global::Timbrar_TXT_XMLPDF.Properties.Settings.Default.Timbrar_TXT_XMLPDF_WsColombia_Main;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event TimbreEnviaTXT32CompletedEventHandler TimbreEnviaTXT32Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IMain/TimbreEnviaTXT32", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ResponseTimbre TimbreEnviaTXT32([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string user, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string userPassword, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)] byte[] ContenidoArchivoTexto, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string NombreArchivo) {
            object[] results = this.Invoke("TimbreEnviaTXT32", new object[] {
                        user,
                        userPassword,
                        ContenidoArchivoTexto,
                        NombreArchivo});
            return ((ResponseTimbre)(results[0]));
        }
        
        /// <remarks/>
        public void TimbreEnviaTXT32Async(string user, string userPassword, byte[] ContenidoArchivoTexto, string NombreArchivo) {
            this.TimbreEnviaTXT32Async(user, userPassword, ContenidoArchivoTexto, NombreArchivo, null);
        }
        
        /// <remarks/>
        public void TimbreEnviaTXT32Async(string user, string userPassword, byte[] ContenidoArchivoTexto, string NombreArchivo, object userState) {
            if ((this.TimbreEnviaTXT32OperationCompleted == null)) {
                this.TimbreEnviaTXT32OperationCompleted = new System.Threading.SendOrPostCallback(this.OnTimbreEnviaTXT32OperationCompleted);
            }
            this.InvokeAsync("TimbreEnviaTXT32", new object[] {
                        user,
                        userPassword,
                        ContenidoArchivoTexto,
                        NombreArchivo}, this.TimbreEnviaTXT32OperationCompleted, userState);
        }
        
        private void OnTimbreEnviaTXT32OperationCompleted(object arg) {
            if ((this.TimbreEnviaTXT32Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TimbreEnviaTXT32Completed(this, new TimbreEnviaTXT32CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Services")]
    public partial class ResponseTimbre {
        
        private int codigoField;
        
        private bool codigoFieldSpecified;
        
        private string mensajeField;
        
        private string pDFField;
        
        private string uUIDField;
        
        private string xmlField;
        
        private string xmlSignField;
        
        /// <remarks/>
        public int Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodigoSpecified {
            get {
                return this.codigoFieldSpecified;
            }
            set {
                this.codigoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string PDF {
            get {
                return this.pDFField;
            }
            set {
                this.pDFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Xml {
            get {
                return this.xmlField;
            }
            set {
                this.xmlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string XmlSign {
            get {
                return this.xmlSignField;
            }
            set {
                this.xmlSignField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void TimbreEnviaTXT32CompletedEventHandler(object sender, TimbreEnviaTXT32CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TimbreEnviaTXT32CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TimbreEnviaTXT32CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseTimbre Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseTimbre)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591