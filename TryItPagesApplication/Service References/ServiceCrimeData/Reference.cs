﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItPagesApplication.ServiceCrimeData {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCrimeData.IServiceCrimeData")]
    public interface IServiceCrimeData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCrimeData/getCrimeData", ReplyAction="http://tempuri.org/IServiceCrimeData/getCrimeDataResponse")]
        int[] getCrimeData(int zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCrimeData/getCrimeData", ReplyAction="http://tempuri.org/IServiceCrimeData/getCrimeDataResponse")]
        System.Threading.Tasks.Task<int[]> getCrimeDataAsync(int zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCrimeData/getCrimeIndex", ReplyAction="http://tempuri.org/IServiceCrimeData/getCrimeIndexResponse")]
        int getCrimeIndex(int zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCrimeData/getCrimeIndex", ReplyAction="http://tempuri.org/IServiceCrimeData/getCrimeIndexResponse")]
        System.Threading.Tasks.Task<int> getCrimeIndexAsync(int zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCrimeData/getLatitudeLongitude", ReplyAction="http://tempuri.org/IServiceCrimeData/getLatitudeLongitudeResponse")]
        string getLatitudeLongitude(int zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCrimeData/getLatitudeLongitude", ReplyAction="http://tempuri.org/IServiceCrimeData/getLatitudeLongitudeResponse")]
        System.Threading.Tasks.Task<string> getLatitudeLongitudeAsync(int zipCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCrimeDataChannel : TryItPagesApplication.ServiceCrimeData.IServiceCrimeData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCrimeDataClient : System.ServiceModel.ClientBase<TryItPagesApplication.ServiceCrimeData.IServiceCrimeData>, TryItPagesApplication.ServiceCrimeData.IServiceCrimeData {
        
        public ServiceCrimeDataClient() {
        }
        
        public ServiceCrimeDataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCrimeDataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCrimeDataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCrimeDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] getCrimeData(int zipCode) {
            return base.Channel.getCrimeData(zipCode);
        }
        
        public System.Threading.Tasks.Task<int[]> getCrimeDataAsync(int zipCode) {
            return base.Channel.getCrimeDataAsync(zipCode);
        }
        
        public int getCrimeIndex(int zipCode) {
            return base.Channel.getCrimeIndex(zipCode);
        }
        
        public System.Threading.Tasks.Task<int> getCrimeIndexAsync(int zipCode) {
            return base.Channel.getCrimeIndexAsync(zipCode);
        }
        
        public string getLatitudeLongitude(int zipCode) {
            return base.Channel.getLatitudeLongitude(zipCode);
        }
        
        public System.Threading.Tasks.Task<string> getLatitudeLongitudeAsync(int zipCode) {
            return base.Channel.getLatitudeLongitudeAsync(zipCode);
        }
    }
}
