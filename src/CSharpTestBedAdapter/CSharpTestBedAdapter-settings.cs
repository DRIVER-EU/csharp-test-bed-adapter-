//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class settings {
        
        private string clientidField;
        
        private ushort heartbeatintervalField;

        private string securityprotocolField;
        
        private string securitycertificatepathField;
        
        private string securitykeystorepathField;
        
        private string securitykeystorepasswordField;
        
        private string brokerurlField;
        
        private string schemaurlField;
        
        private bool sendsyncField;
        
        private byte retrycountField;
        
        private ushort retrytimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client.id")]
        public string clientid {
            get {
                return this.clientidField;
            }
            set {
                this.clientidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("heartbeat.interval")]
        public ushort heartbeatinterval {
            get {
                return this.heartbeatintervalField;
            }
            set {
                this.heartbeatintervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("security.protocol")]
        public string securityprotocol
        {
            get
            {
                return this.securityprotocolField;
            }
            set
            {
                this.securityprotocolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("security.certificate.path")]
        public string securitycertificatepath {
            get {
                return this.securitycertificatepathField;
            }
            set {
                this.securitycertificatepathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("security.keystore.path")]
        public string securitykeystorepath {
            get {
                return this.securitykeystorepathField;
            }
            set {
                this.securitykeystorepathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("security.keystore.password")]
        public string securitykeystorepassword {
            get {
                return this.securitykeystorepasswordField;
            }
            set {
                this.securitykeystorepasswordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("broker.url")]
        public string brokerurl {
            get {
                return this.brokerurlField;
            }
            set {
                this.brokerurlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schema.url")]
        public string schemaurl {
            get {
                return this.schemaurlField;
            }
            set {
                this.schemaurlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("send.sync")]
        public bool sendsync {
            get {
                return this.sendsyncField;
            }
            set {
                this.sendsyncField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("retry.count")]
        public byte retrycount {
            get {
                return this.retrycountField;
            }
            set {
                this.retrycountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("retry.time")]
        public ushort retrytime {
            get {
                return this.retrytimeField;
            }
            set {
                this.retrytimeField = value;
            }
        }
    }
}
