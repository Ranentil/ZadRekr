﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UslugaBIR
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParametryWyszukiwania", Namespace="http://CIS/BIR/PUBL/2014/07/DataContract")]
    public partial class ParametryWyszukiwania : object
    {
        
        private string KrsField;
        
        private string KrsyField;
        
        private string NipField;
        
        private string NipyField;
        
        private string RegonField;
        
        private string Regony14znField;
        
        private string Regony9znField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krs
        {
            get
            {
                return this.KrsField;
            }
            set
            {
                this.KrsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krsy
        {
            get
            {
                return this.KrsyField;
            }
            set
            {
                this.KrsyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nip
        {
            get
            {
                return this.NipField;
            }
            set
            {
                this.NipField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nipy
        {
            get
            {
                return this.NipyField;
            }
            set
            {
                this.NipyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regon
        {
            get
            {
                return this.RegonField;
            }
            set
            {
                this.RegonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony14zn
        {
            get
            {
                return this.Regony14znField;
            }
            set
            {
                this.Regony14znField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony9zn
        {
            get
            {
                return this.Regony9znField;
            }
            set
            {
                this.Regony9znField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UslugaBIR.IUslugaBIRzewnPubl")]
    public interface IUslugaBIRzewnPubl
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        System.Threading.Tasks.Task<UslugaBIR.GetValueResponse> GetValueAsync(UslugaBIR.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        System.Threading.Tasks.Task<UslugaBIR.ZalogujResponse> ZalogujAsync(UslugaBIR.ZalogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        System.Threading.Tasks.Task<UslugaBIR.WylogujResponse> WylogujAsync(UslugaBIR.WylogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        System.Threading.Tasks.Task<UslugaBIR.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(UslugaBIR.DaneSzukajPodmiotyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        System.Threading.Tasks.Task<UslugaBIR.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(UslugaBIR.DanePobierzPelnyRaportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        System.Threading.Tasks.Task<UslugaBIR.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(UslugaBIR.DanePobierzRaportZbiorczyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        public GetValueRequest()
        {
        }
        
        public GetValueRequest(string pNazwaParametru)
        {
            this.pNazwaParametru = pNazwaParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string GetValueResult;
        
        public GetValueResponse()
        {
        }
        
        public GetValueResponse(string GetValueResult)
        {
            this.GetValueResult = GetValueResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Zaloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pKluczUzytkownika;
        
        public ZalogujRequest()
        {
        }
        
        public ZalogujRequest(string pKluczUzytkownika)
        {
            this.pKluczUzytkownika = pKluczUzytkownika;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ZalogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string ZalogujResult;
        
        public ZalogujResponse()
        {
        }
        
        public ZalogujResponse(string ZalogujResult)
        {
            this.ZalogujResult = ZalogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Wyloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pIdentyfikatorSesji;
        
        public WylogujRequest()
        {
        }
        
        public WylogujRequest(string pIdentyfikatorSesji)
        {
            this.pIdentyfikatorSesji = pIdentyfikatorSesji;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WylogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public bool WylogujResult;
        
        public WylogujResponse()
        {
        }
        
        public WylogujResponse(bool WylogujResult)
        {
            this.WylogujResult = WylogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmioty", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania;
        
        public DaneSzukajPodmiotyRequest()
        {
        }
        
        public DaneSzukajPodmiotyRequest(UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania)
        {
            this.pParametryWyszukiwania = pParametryWyszukiwania;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmiotyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DaneSzukajPodmiotyResult;
        
        public DaneSzukajPodmiotyResponse()
        {
        }
        
        public DaneSzukajPodmiotyResponse(string DaneSzukajPodmiotyResult)
        {
            this.DaneSzukajPodmiotyResult = DaneSzukajPodmiotyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaport", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pRegon;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzPelnyRaportRequest()
        {
        }
        
        public DanePobierzPelnyRaportRequest(string pRegon, string pNazwaRaportu)
        {
            this.pRegon = pRegon;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaportResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzPelnyRaportResult;
        
        public DanePobierzPelnyRaportResponse()
        {
        }
        
        public DanePobierzPelnyRaportResponse(string DanePobierzPelnyRaportResult)
        {
            this.DanePobierzPelnyRaportResult = DanePobierzPelnyRaportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczy", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pDataRaportu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzRaportZbiorczyRequest()
        {
        }
        
        public DanePobierzRaportZbiorczyRequest(string pDataRaportu, string pNazwaRaportu)
        {
            this.pDataRaportu = pDataRaportu;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzRaportZbiorczyResult;
        
        public DanePobierzRaportZbiorczyResponse()
        {
        }
        
        public DanePobierzRaportZbiorczyResponse(string DanePobierzRaportZbiorczyResult)
        {
            this.DanePobierzRaportZbiorczyResult = DanePobierzRaportZbiorczyResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IUslugaBIRzewnPublChannel : UslugaBIR.IUslugaBIRzewnPubl, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class UslugaBIRzewnPublClient : System.ServiceModel.ClientBase<UslugaBIR.IUslugaBIRzewnPubl>, UslugaBIR.IUslugaBIRzewnPubl
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UslugaBIRzewnPublClient() : 
                base(UslugaBIRzewnPublClient.GetDefaultBinding(), UslugaBIRzewnPublClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.e3.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(EndpointConfiguration endpointConfiguration) : 
                base(UslugaBIRzewnPublClient.GetBindingForEndpoint(endpointConfiguration), UslugaBIRzewnPublClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UslugaBIRzewnPublClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UslugaBIRzewnPublClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UslugaBIRzewnPublClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UslugaBIR.GetValueResponse> UslugaBIR.IUslugaBIRzewnPubl.GetValueAsync(UslugaBIR.GetValueRequest request)
        {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<UslugaBIR.GetValueResponse> GetValueAsync(string pNazwaParametru)
        {
            UslugaBIR.GetValueRequest inValue = new UslugaBIR.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            return ((UslugaBIR.IUslugaBIRzewnPubl)(this)).GetValueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UslugaBIR.ZalogujResponse> UslugaBIR.IUslugaBIRzewnPubl.ZalogujAsync(UslugaBIR.ZalogujRequest request)
        {
            return base.Channel.ZalogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<UslugaBIR.ZalogujResponse> ZalogujAsync(string pKluczUzytkownika)
        {
            UslugaBIR.ZalogujRequest inValue = new UslugaBIR.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            return ((UslugaBIR.IUslugaBIRzewnPubl)(this)).ZalogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UslugaBIR.WylogujResponse> UslugaBIR.IUslugaBIRzewnPubl.WylogujAsync(UslugaBIR.WylogujRequest request)
        {
            return base.Channel.WylogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<UslugaBIR.WylogujResponse> WylogujAsync(string pIdentyfikatorSesji)
        {
            UslugaBIR.WylogujRequest inValue = new UslugaBIR.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            return ((UslugaBIR.IUslugaBIRzewnPubl)(this)).WylogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UslugaBIR.DaneSzukajPodmiotyResponse> UslugaBIR.IUslugaBIRzewnPubl.DaneSzukajPodmiotyAsync(UslugaBIR.DaneSzukajPodmiotyRequest request)
        {
            return base.Channel.DaneSzukajPodmiotyAsync(request);
        }
        
        public System.Threading.Tasks.Task<UslugaBIR.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(UslugaBIR.ParametryWyszukiwania pParametryWyszukiwania)
        {
            UslugaBIR.DaneSzukajPodmiotyRequest inValue = new UslugaBIR.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            return ((UslugaBIR.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmiotyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UslugaBIR.DanePobierzPelnyRaportResponse> UslugaBIR.IUslugaBIRzewnPubl.DanePobierzPelnyRaportAsync(UslugaBIR.DanePobierzPelnyRaportRequest request)
        {
            return base.Channel.DanePobierzPelnyRaportAsync(request);
        }
        
        public System.Threading.Tasks.Task<UslugaBIR.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu)
        {
            UslugaBIR.DanePobierzPelnyRaportRequest inValue = new UslugaBIR.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((UslugaBIR.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UslugaBIR.DanePobierzRaportZbiorczyResponse> UslugaBIR.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczyAsync(UslugaBIR.DanePobierzRaportZbiorczyRequest request)
        {
            return base.Channel.DanePobierzRaportZbiorczyAsync(request);
        }
        
        public System.Threading.Tasks.Task<UslugaBIR.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(string pDataRaportu, string pNazwaRaportu)
        {
            UslugaBIR.DanePobierzRaportZbiorczyRequest inValue = new UslugaBIR.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((UslugaBIR.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczyAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.e3))
            {
                System.ServiceModel.WSHttpBinding result = new System.ServiceModel.WSHttpBinding();
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.SecurityMode.Transport;
                result.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.None;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.e3))
            {
                return new System.ServiceModel.EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UslugaBIRzewnPublClient.GetBindingForEndpoint(EndpointConfiguration.e3);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UslugaBIRzewnPublClient.GetEndpointAddress(EndpointConfiguration.e3);
        }
        
        public enum EndpointConfiguration
        {
            
            e3,
        }
    }
}
