﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="CisteraScreenCaptureService.IUiApi", CallbackContract=typeof(Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.IUiApiCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IUiApi {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:IUiApi/Subscribe")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:IUiApi/Subscribe")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:IUiApi/Unsubscribe")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:IUiApi/Unsubscribe")]
        System.Threading.Tasks.Task UnsubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IUiApi/GetSettings", ReplyAction="urn:IUiApi/GetSettingsResponse")]
        Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsResponse GetSettings(Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:IUiApi/GetSettings", ReplyAction="urn:IUiApi/GetSettingsResponse")]
        System.Threading.Tasks.Task<Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsResponse> GetSettingsAsync(Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IUiApi/IsAlive", ReplyAction="urn:IUiApi/IsAliveResponse")]
        bool IsAlive();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IUiApi/IsAlive", ReplyAction="urn:IUiApi/IsAliveResponse")]
        System.Threading.Tasks.Task<bool> IsAliveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUiApiCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:IUiApi/ServiceStatusChanged")]
        void ServiceStatusChanged(System.ServiceProcess.ServiceControllerStatus status);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="urn:IUiApi/Message")]
        void Message(Cliver.CisteraScreenCaptureService.MessageType messageType, [System.ServiceModel.MessageParameterAttribute(Name="message")] string message1);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSettings", WrapperNamespace="", IsWrapped=true)]
    public partial class GetSettingsRequest {
        
        public GetSettingsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSettingsResponse", WrapperNamespace="", IsWrapped=true)]
    public partial class GetSettingsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public Cliver.CisteraScreenCaptureService.Settings.GeneralSettings GetSettingsResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string @__file;
        
        public GetSettingsResponse() {
        }
        
        public GetSettingsResponse(Cliver.CisteraScreenCaptureService.Settings.GeneralSettings GetSettingsResult, string @__file) {
            this.GetSettingsResult = GetSettingsResult;
            this.@__file = @__file;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUiApiChannel : Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.IUiApi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UiApiClient : System.ServiceModel.DuplexClientBase<Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.IUiApi>, Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.IUiApi {
        
        public UiApiClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public UiApiClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public UiApiClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public UiApiClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public UiApiClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void Unsubscribe() {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsResponse Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.IUiApi.GetSettings(Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsRequest request) {
            return base.Channel.GetSettings(request);
        }
        
        public Cliver.CisteraScreenCaptureService.Settings.GeneralSettings GetSettings(out string @__file) {
            Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsRequest inValue = new Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsRequest();
            Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsResponse retVal = ((Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.IUiApi)(this)).GetSettings(inValue);
            @__file = retVal.@__file;
            return retVal.GetSettingsResult;
        }
        
        public System.Threading.Tasks.Task<Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsResponse> GetSettingsAsync(Cliver.CisteraScreenCaptureUI.CisteraScreenCaptureService.GetSettingsRequest request) {
            return base.Channel.GetSettingsAsync(request);
        }
        
        public bool IsAlive() {
            return base.Channel.IsAlive();
        }
        
        public System.Threading.Tasks.Task<bool> IsAliveAsync() {
            return base.Channel.IsAliveAsync();
        }
    }
}
