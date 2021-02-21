﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeofBuySell.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/BuySell")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public string Iname {
            get {
                return this.InameField;
            }
            set {
                if ((object.ReferenceEquals(this.InameField, value) != true)) {
                    this.InameField = value;
                    this.RaisePropertyChanged("Iname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Prize {
            get {
                return this.PrizeField;
            }
            set {
                if ((this.PrizeField.Equals(value) != true)) {
                    this.PrizeField = value;
                    this.RaisePropertyChanged("Prize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetItem", ReplyAction="http://tempuri.org/IService1/GetItemResponse")]
        ConsumeofBuySell.ServiceReference1.Item[] GetItem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetItem", ReplyAction="http://tempuri.org/IService1/GetItemResponse")]
        System.Threading.Tasks.Task<ConsumeofBuySell.ServiceReference1.Item[]> GetItemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        void Add(ConsumeofBuySell.ServiceReference1.Item obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task AddAsync(ConsumeofBuySell.ServiceReference1.Item obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        void Update(ConsumeofBuySell.ServiceReference1.Item obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(ConsumeofBuySell.ServiceReference1.Item obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsumeofBuySell.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsumeofBuySell.ServiceReference1.IService1>, ConsumeofBuySell.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsumeofBuySell.ServiceReference1.Item[] GetItem() {
            return base.Channel.GetItem();
        }
        
        public System.Threading.Tasks.Task<ConsumeofBuySell.ServiceReference1.Item[]> GetItemAsync() {
            return base.Channel.GetItemAsync();
        }
        
        public void Add(ConsumeofBuySell.ServiceReference1.Item obj) {
            base.Channel.Add(obj);
        }
        
        public System.Threading.Tasks.Task AddAsync(ConsumeofBuySell.ServiceReference1.Item obj) {
            return base.Channel.AddAsync(obj);
        }
        
        public void Update(ConsumeofBuySell.ServiceReference1.Item obj) {
            base.Channel.Update(obj);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(ConsumeofBuySell.ServiceReference1.Item obj) {
            return base.Channel.UpdateAsync(obj);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
