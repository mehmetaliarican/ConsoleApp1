﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TNBSN
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", ConfigurationName="TNBSN.Servis")]
    public interface Servis
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas/Servis/EOdemeSaticiKaydetRequest", ReplyAction="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas/Servis/EOdemeSaticiKaydetResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EOdemeBaseResponse))]
        System.Threading.Tasks.Task<TNBSN.EOdemeSaticiKaydetResponse1> EOdemeSaticiKaydetAsync(TNBSN.EOdemeSaticiKaydetRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas/Servis/EOdemeIptalEtRequest", ReplyAction="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas/Servis/EOdemeIptalEtResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EOdemeBaseResponse))]
        System.Threading.Tasks.Task<TNBSN.EOdemeIptalEtResponse1> EOdemeIptalEtAsync(TNBSN.EOdemeIptalEtRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas/Servis/EOdemeAliciKaydetRequest", ReplyAction="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas/Servis/EOdemeAliciKaydetResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EOdemeBaseResponse))]
        System.Threading.Tasks.Task<TNBSN.EOdemeAliciKaydetResponse1> EOdemeAliciKaydetAsync(TNBSN.EOdemeAliciKaydetRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public partial class EOdemeSaticiKaydetRequest
    {
        
        private string kurumKoduField;
        
        private string saticiKimlikNoField;
        
        private string plakaField;
        
        private decimal tutarField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string kurumKodu
        {
            get
            {
                return this.kurumKoduField;
            }
            set
            {
                this.kurumKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string saticiKimlikNo
        {
            get
            {
                return this.saticiKimlikNoField;
            }
            set
            {
                this.saticiKimlikNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string plaka
        {
            get
            {
                return this.plakaField;
            }
            set
            {
                this.plakaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal tutar
        {
            get
            {
                return this.tutarField;
            }
            set
            {
                this.tutarField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public abstract partial class EOdemeBaseResponse
    {
        
        private bool sonucField;
        
        private int hataKoduField;
        
        private bool hataKoduFieldSpecified;
        
        private string hataMesajiField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool sonuc
        {
            get
            {
                return this.sonucField;
            }
            set
            {
                this.sonucField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int hataKodu
        {
            get
            {
                return this.hataKoduField;
            }
            set
            {
                this.hataKoduField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hataKoduSpecified
        {
            get
            {
                return this.hataKoduFieldSpecified;
            }
            set
            {
                this.hataKoduFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string hataMesaji
        {
            get
            {
                return this.hataMesajiField;
            }
            set
            {
                this.hataMesajiField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public partial class EOdemeSaticiKaydetResponse : EOdemeBaseResponse
    {
        
        private string refNoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string refNo
        {
            get
            {
                return this.refNoField;
            }
            set
            {
                this.refNoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EOdemeSaticiKaydetRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", Order=0)]
        public TNBSN.EOdemeSaticiKaydetRequest EOdemeSaticiKaydetRequest;
        
        public EOdemeSaticiKaydetRequest1()
        {
        }
        
        public EOdemeSaticiKaydetRequest1(TNBSN.EOdemeSaticiKaydetRequest EOdemeSaticiKaydetRequest)
        {
            this.EOdemeSaticiKaydetRequest = EOdemeSaticiKaydetRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EOdemeSaticiKaydetResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", Order=0)]
        public TNBSN.EOdemeSaticiKaydetResponse EOdemeSaticiKaydetResponse;
        
        public EOdemeSaticiKaydetResponse1()
        {
        }
        
        public EOdemeSaticiKaydetResponse1(TNBSN.EOdemeSaticiKaydetResponse EOdemeSaticiKaydetResponse)
        {
            this.EOdemeSaticiKaydetResponse = EOdemeSaticiKaydetResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public partial class EOdemeIptalEtRequest
    {
        
        private string refNoField;
        
        private string iptalTuruField;
        
        private string iptalNedeniField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string refNo
        {
            get
            {
                return this.refNoField;
            }
            set
            {
                this.refNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string iptalTuru
        {
            get
            {
                return this.iptalTuruField;
            }
            set
            {
                this.iptalTuruField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string iptalNedeni
        {
            get
            {
                return this.iptalNedeniField;
            }
            set
            {
                this.iptalNedeniField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public partial class EOdemeIptalEtResponse : EOdemeBaseResponse
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EOdemeIptalEtRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", Order=0)]
        public TNBSN.EOdemeIptalEtRequest EOdemeIptalEtRequest;
        
        public EOdemeIptalEtRequest1()
        {
        }
        
        public EOdemeIptalEtRequest1(TNBSN.EOdemeIptalEtRequest EOdemeIptalEtRequest)
        {
            this.EOdemeIptalEtRequest = EOdemeIptalEtRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EOdemeIptalEtResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", Order=0)]
        public TNBSN.EOdemeIptalEtResponse EOdemeIptalEtResponse;
        
        public EOdemeIptalEtResponse1()
        {
        }
        
        public EOdemeIptalEtResponse1(TNBSN.EOdemeIptalEtResponse EOdemeIptalEtResponse)
        {
            this.EOdemeIptalEtResponse = EOdemeIptalEtResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public partial class EOdemeAliciKaydetRequest
    {
        
        private string refNoField;
        
        private string aliciKimlikNoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string refNo
        {
            get
            {
                return this.refNoField;
            }
            set
            {
                this.refNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string aliciKimlikNo
        {
            get
            {
                return this.aliciKimlikNoField;
            }
            set
            {
                this.aliciKimlikNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas")]
    public partial class EOdemeAliciKaydetResponse : EOdemeBaseResponse
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EOdemeAliciKaydetRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", Order=0)]
        public TNBSN.EOdemeAliciKaydetRequest EOdemeAliciKaydetRequest;
        
        public EOdemeAliciKaydetRequest1()
        {
        }
        
        public EOdemeAliciKaydetRequest1(TNBSN.EOdemeAliciKaydetRequest EOdemeAliciKaydetRequest)
        {
            this.EOdemeAliciKaydetRequest = EOdemeAliciKaydetRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EOdemeAliciKaydetResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tnb.org.tr/ws/nbs-e-odeme-ws/schemas", Order=0)]
        public TNBSN.EOdemeAliciKaydetResponse EOdemeAliciKaydetResponse;
        
        public EOdemeAliciKaydetResponse1()
        {
        }
        
        public EOdemeAliciKaydetResponse1(TNBSN.EOdemeAliciKaydetResponse EOdemeAliciKaydetResponse)
        {
            this.EOdemeAliciKaydetResponse = EOdemeAliciKaydetResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ServisChannel : TNBSN.Servis, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServisClient : System.ServiceModel.ClientBase<TNBSN.Servis>, TNBSN.Servis
    {
        
        public ServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TNBSN.EOdemeSaticiKaydetResponse1> TNBSN.Servis.EOdemeSaticiKaydetAsync(TNBSN.EOdemeSaticiKaydetRequest1 request)
        {
            return base.Channel.EOdemeSaticiKaydetAsync(request);
        }
        
        public System.Threading.Tasks.Task<TNBSN.EOdemeSaticiKaydetResponse1> EOdemeSaticiKaydetAsync(TNBSN.EOdemeSaticiKaydetRequest EOdemeSaticiKaydetRequest)
        {
            TNBSN.EOdemeSaticiKaydetRequest1 inValue = new TNBSN.EOdemeSaticiKaydetRequest1();
            inValue.EOdemeSaticiKaydetRequest = EOdemeSaticiKaydetRequest;
            return ((TNBSN.Servis)(this)).EOdemeSaticiKaydetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TNBSN.EOdemeIptalEtResponse1> TNBSN.Servis.EOdemeIptalEtAsync(TNBSN.EOdemeIptalEtRequest1 request)
        {
            return base.Channel.EOdemeIptalEtAsync(request);
        }
        
        public System.Threading.Tasks.Task<TNBSN.EOdemeIptalEtResponse1> EOdemeIptalEtAsync(TNBSN.EOdemeIptalEtRequest EOdemeIptalEtRequest)
        {
            TNBSN.EOdemeIptalEtRequest1 inValue = new TNBSN.EOdemeIptalEtRequest1();
            inValue.EOdemeIptalEtRequest = EOdemeIptalEtRequest;
            return ((TNBSN.Servis)(this)).EOdemeIptalEtAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TNBSN.EOdemeAliciKaydetResponse1> TNBSN.Servis.EOdemeAliciKaydetAsync(TNBSN.EOdemeAliciKaydetRequest1 request)
        {
            return base.Channel.EOdemeAliciKaydetAsync(request);
        }
        
        public System.Threading.Tasks.Task<TNBSN.EOdemeAliciKaydetResponse1> EOdemeAliciKaydetAsync(TNBSN.EOdemeAliciKaydetRequest EOdemeAliciKaydetRequest)
        {
            TNBSN.EOdemeAliciKaydetRequest1 inValue = new TNBSN.EOdemeAliciKaydetRequest1();
            inValue.EOdemeAliciKaydetRequest = EOdemeAliciKaydetRequest;
            return ((TNBSN.Servis)(this)).EOdemeAliciKaydetAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
