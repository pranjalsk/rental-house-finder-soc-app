﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItPagesApplication.NearByStoresService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NearByStoresService.IServiceNearByStores")]
    public interface IServiceNearByStores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNearByStores/findNearestStore", ReplyAction="http://tempuri.org/IServiceNearByStores/findNearestStoreResponse")]
        string findNearestStore(string zip, string storeType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNearByStores/findNearestStore", ReplyAction="http://tempuri.org/IServiceNearByStores/findNearestStoreResponse")]
        System.Threading.Tasks.Task<string> findNearestStoreAsync(string zip, string storeType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNearByStores/getLatLong", ReplyAction="http://tempuri.org/IServiceNearByStores/getLatLongResponse")]
        string getLatLong(string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNearByStores/getLatLong", ReplyAction="http://tempuri.org/IServiceNearByStores/getLatLongResponse")]
        System.Threading.Tasks.Task<string> getLatLongAsync(string zip);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceNearByStoresChannel : TryItPagesApplication.NearByStoresService.IServiceNearByStores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceNearByStoresClient : System.ServiceModel.ClientBase<TryItPagesApplication.NearByStoresService.IServiceNearByStores>, TryItPagesApplication.NearByStoresService.IServiceNearByStores {
        
        public ServiceNearByStoresClient() {
        }
        
        public ServiceNearByStoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceNearByStoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNearByStoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNearByStoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string findNearestStore(string zip, string storeType) {
            return base.Channel.findNearestStore(zip, storeType);
        }
        
        public System.Threading.Tasks.Task<string> findNearestStoreAsync(string zip, string storeType) {
            return base.Channel.findNearestStoreAsync(zip, storeType);
        }
        
        public string getLatLong(string zip) {
            return base.Channel.getLatLong(zip);
        }
        
        public System.Threading.Tasks.Task<string> getLatLongAsync(string zip) {
            return base.Channel.getLatLongAsync(zip);
        }
    }
}
