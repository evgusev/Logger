﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoggerWeb.WcfLoggerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfLogData", Namespace="http://schemas.datacontract.org/2004/07/WcfLoggerService")]
    [System.SerializableAttribute()]
    public partial class WcfLogData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoggerWeb.WcfLoggerService.LogDataModel ModelField;
        
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
        public LoggerWeb.WcfLoggerService.LogDataModel Model {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LogDataModel", Namespace="http://schemas.datacontract.org/2004/07/Logger.Domain")]
    [System.SerializableAttribute()]
    public partial class LogDataModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataSourceTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoggerWeb.WcfLoggerService.LogDataEntry[] LogsField;
        
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
        public string DataSourceType {
            get {
                return this.DataSourceTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.DataSourceTypeField, value) != true)) {
                    this.DataSourceTypeField = value;
                    this.RaisePropertyChanged("DataSourceType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LoggerWeb.WcfLoggerService.LogDataEntry[] Logs {
            get {
                return this.LogsField;
            }
            set {
                if ((object.ReferenceEquals(this.LogsField, value) != true)) {
                    this.LogsField = value;
                    this.RaisePropertyChanged("Logs");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LogDataEntry", Namespace="http://schemas.datacontract.org/2004/07/Logger.Domain")]
    [System.SerializableAttribute()]
    public partial class LogDataEntry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CurrentTimeField;
        
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
        public System.DateTime CurrentTime {
            get {
                return this.CurrentTimeField;
            }
            set {
                if ((this.CurrentTimeField.Equals(value) != true)) {
                    this.CurrentTimeField = value;
                    this.RaisePropertyChanged("CurrentTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfLoggerService.ILogGetter")]
    public interface ILogGetter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogGetter/GetLogs", ReplyAction="http://tempuri.org/ILogGetter/GetLogsResponse")]
        LoggerWeb.WcfLoggerService.WcfLogData GetLogs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogGetter/GetLogs", ReplyAction="http://tempuri.org/ILogGetter/GetLogsResponse")]
        System.Threading.Tasks.Task<LoggerWeb.WcfLoggerService.WcfLogData> GetLogsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogGetterChannel : LoggerWeb.WcfLoggerService.ILogGetter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogGetterClient : System.ServiceModel.ClientBase<LoggerWeb.WcfLoggerService.ILogGetter>, LoggerWeb.WcfLoggerService.ILogGetter {
        
        public LogGetterClient() {
        }
        
        public LogGetterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogGetterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogGetterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogGetterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LoggerWeb.WcfLoggerService.WcfLogData GetLogs() {
            return base.Channel.GetLogs();
        }
        
        public System.Threading.Tasks.Task<LoggerWeb.WcfLoggerService.WcfLogData> GetLogsAsync() {
            return base.Channel.GetLogsAsync();
        }
    }
}