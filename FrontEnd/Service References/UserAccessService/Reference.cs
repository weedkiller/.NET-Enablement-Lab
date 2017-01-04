﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontEnd.UserAccessService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://appdynamics.com/Demo", ConfigurationName="UserAccessService.UserAccessService")]
    public interface UserAccessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="ValidateAccess", ReplyAction="http://appdynamics.com/Demo/UserAccessService/ValidateAccessResponse")]
        bool ValidateAccess(string userName, string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="ValidateAccess", ReplyAction="http://appdynamics.com/Demo/UserAccessService/ValidateAccessResponse")]
        System.Threading.Tasks.Task<bool> ValidateAccessAsync(string userName, string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="Authenticate", ReplyAction="http://appdynamics.com/Demo/UserAccessService/AuthenticateResponse")]
        bool Authenticate(string userId, bool mobile, int provider);
        
        [System.ServiceModel.OperationContractAttribute(Action="Authenticate", ReplyAction="http://appdynamics.com/Demo/UserAccessService/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(string userId, bool mobile, int provider);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserAccessServiceChannel : FrontEnd.UserAccessService.UserAccessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserAccessServiceClient : System.ServiceModel.ClientBase<FrontEnd.UserAccessService.UserAccessService>, FrontEnd.UserAccessService.UserAccessService {
        
        public UserAccessServiceClient() {
        }
        
        public UserAccessServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserAccessServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserAccessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserAccessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidateAccess(string userName, string userId) {
            return base.Channel.ValidateAccess(userName, userId);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateAccessAsync(string userName, string userId) {
            return base.Channel.ValidateAccessAsync(userName, userId);
        }
        
        public bool Authenticate(string userId, bool mobile, int provider) {
            return base.Channel.Authenticate(userId, mobile, provider);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(string userId, bool mobile, int provider) {
            return base.Channel.AuthenticateAsync(userId, mobile, provider);
        }
    }
}
