﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS4_Registracija_Client.RegistracijaServis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vlasnik", Namespace="http://schemas.datacontract.org/2004/07/DS4_Registracija")]
    [System.SerializableAttribute()]
    public partial class Vlasnik : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JMBGField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrezimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JMBG {
            get {
                return this.JMBGField;
            }
            set {
                if ((object.ReferenceEquals(this.JMBGField, value) != true)) {
                    this.JMBGField = value;
                    this.RaisePropertyChanged("JMBG");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prezime {
            get {
                return this.PrezimeField;
            }
            set {
                if ((object.ReferenceEquals(this.PrezimeField, value) != true)) {
                    this.PrezimeField = value;
                    this.RaisePropertyChanged("Prezime");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vozilo", Namespace="http://schemas.datacontract.org/2004/07/DS4_Registracija")]
    [System.SerializableAttribute()]
    public partial class Vozilo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Drawing.Color BojaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Drawing.Color Boja {
            get {
                return this.BojaField;
            }
            set {
                if ((this.BojaField.Equals(value) != true)) {
                    this.BojaField = value;
                    this.RaisePropertyChanged("Boja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marka {
            get {
                return this.MarkaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarkaField, value) != true)) {
                    this.MarkaField = value;
                    this.RaisePropertyChanged("Marka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://DS4_Registracija", ConfigurationName="RegistracijaServis.IRegistracijaServis", CallbackContract=typeof(DS4_Registracija_Client.RegistracijaServis.IRegistracijaServisCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IRegistracijaServis {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/RegistrujVozilo", ReplyAction="http://DS4_Registracija/IRegistracijaServis/RegistrujVoziloResponse")]
        void RegistrujVozilo(DS4_Registracija_Client.RegistracijaServis.Vlasnik v, DS4_Registracija_Client.RegistracijaServis.Vozilo z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/RegistrujVozilo", ReplyAction="http://DS4_Registracija/IRegistracijaServis/RegistrujVoziloResponse")]
        System.Threading.Tasks.Task RegistrujVoziloAsync(DS4_Registracija_Client.RegistracijaServis.Vlasnik v, DS4_Registracija_Client.RegistracijaServis.Vozilo z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/VratiVozila", ReplyAction="http://DS4_Registracija/IRegistracijaServis/VratiVozilaResponse")]
        DS4_Registracija_Client.RegistracijaServis.Vozilo[] VratiVozila(DS4_Registracija_Client.RegistracijaServis.Vlasnik v);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/VratiVozila", ReplyAction="http://DS4_Registracija/IRegistracijaServis/VratiVozilaResponse")]
        System.Threading.Tasks.Task<DS4_Registracija_Client.RegistracijaServis.Vozilo[]> VratiVozilaAsync(DS4_Registracija_Client.RegistracijaServis.Vlasnik v);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/VratiVlasnike", ReplyAction="http://DS4_Registracija/IRegistracijaServis/VratiVlasnikeResponse")]
        DS4_Registracija_Client.RegistracijaServis.Vlasnik[] VratiVlasnike(string marka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/VratiVlasnike", ReplyAction="http://DS4_Registracija/IRegistracijaServis/VratiVlasnikeResponse")]
        System.Threading.Tasks.Task<DS4_Registracija_Client.RegistracijaServis.Vlasnik[]> VratiVlasnikeAsync(string marka);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/VratiSve", ReplyAction="http://DS4_Registracija/IRegistracijaServis/VratiSveResponse")]
        System.Collections.Generic.Dictionary<DS4_Registracija_Client.RegistracijaServis.Vlasnik, DS4_Registracija_Client.RegistracijaServis.Vozilo[]> VratiSve();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://DS4_Registracija/IRegistracijaServis/VratiSve", ReplyAction="http://DS4_Registracija/IRegistracijaServis/VratiSveResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<DS4_Registracija_Client.RegistracijaServis.Vlasnik, DS4_Registracija_Client.RegistracijaServis.Vozilo[]>> VratiSveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistracijaServisCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://DS4_Registracija/IRegistracijaServis/Obavesti")]
        void Obavesti(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistracijaServisChannel : DS4_Registracija_Client.RegistracijaServis.IRegistracijaServis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistracijaServisClient : System.ServiceModel.DuplexClientBase<DS4_Registracija_Client.RegistracijaServis.IRegistracijaServis>, DS4_Registracija_Client.RegistracijaServis.IRegistracijaServis {
        
        public RegistracijaServisClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public RegistracijaServisClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public RegistracijaServisClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RegistracijaServisClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RegistracijaServisClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RegistrujVozilo(DS4_Registracija_Client.RegistracijaServis.Vlasnik v, DS4_Registracija_Client.RegistracijaServis.Vozilo z) {
            base.Channel.RegistrujVozilo(v, z);
        }
        
        public System.Threading.Tasks.Task RegistrujVoziloAsync(DS4_Registracija_Client.RegistracijaServis.Vlasnik v, DS4_Registracija_Client.RegistracijaServis.Vozilo z) {
            return base.Channel.RegistrujVoziloAsync(v, z);
        }
        
        public DS4_Registracija_Client.RegistracijaServis.Vozilo[] VratiVozila(DS4_Registracija_Client.RegistracijaServis.Vlasnik v) {
            return base.Channel.VratiVozila(v);
        }
        
        public System.Threading.Tasks.Task<DS4_Registracija_Client.RegistracijaServis.Vozilo[]> VratiVozilaAsync(DS4_Registracija_Client.RegistracijaServis.Vlasnik v) {
            return base.Channel.VratiVozilaAsync(v);
        }
        
        public DS4_Registracija_Client.RegistracijaServis.Vlasnik[] VratiVlasnike(string marka) {
            return base.Channel.VratiVlasnike(marka);
        }
        
        public System.Threading.Tasks.Task<DS4_Registracija_Client.RegistracijaServis.Vlasnik[]> VratiVlasnikeAsync(string marka) {
            return base.Channel.VratiVlasnikeAsync(marka);
        }
        
        public System.Collections.Generic.Dictionary<DS4_Registracija_Client.RegistracijaServis.Vlasnik, DS4_Registracija_Client.RegistracijaServis.Vozilo[]> VratiSve() {
            return base.Channel.VratiSve();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<DS4_Registracija_Client.RegistracijaServis.Vlasnik, DS4_Registracija_Client.RegistracijaServis.Vozilo[]>> VratiSveAsync() {
            return base.Channel.VratiSveAsync();
        }
    }
}