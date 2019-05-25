﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS4_Bank_Client.BankService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankService.IBankService")]
    public interface IBankService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/UpdateBalance", ReplyAction="http://tempuri.org/IBankService/UpdateBalanceResponse")]
        void UpdateBalance(double d, string name, double coef);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/UpdateBalance", ReplyAction="http://tempuri.org/IBankService/UpdateBalanceResponse")]
        System.Threading.Tasks.Task UpdateBalanceAsync(double d, string name, double coef);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/Withdraw", ReplyAction="http://tempuri.org/IBankService/WithdrawResponse")]
        void Withdraw(double d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/Withdraw", ReplyAction="http://tempuri.org/IBankService/WithdrawResponse")]
        System.Threading.Tasks.Task WithdrawAsync(double d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/ShowInDinars", ReplyAction="http://tempuri.org/IBankService/ShowInDinarsResponse")]
        double ShowInDinars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/ShowInDinars", ReplyAction="http://tempuri.org/IBankService/ShowInDinarsResponse")]
        System.Threading.Tasks.Task<double> ShowInDinarsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankServiceChannel : DS4_Bank_Client.BankService.IBankService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankServiceClient : System.ServiceModel.ClientBase<DS4_Bank_Client.BankService.IBankService>, DS4_Bank_Client.BankService.IBankService {
        
        public BankServiceClient() {
        }
        
        public BankServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void UpdateBalance(double d, string name, double coef) {
            base.Channel.UpdateBalance(d, name, coef);
        }
        
        public System.Threading.Tasks.Task UpdateBalanceAsync(double d, string name, double coef) {
            return base.Channel.UpdateBalanceAsync(d, name, coef);
        }
        
        public void Withdraw(double d) {
            base.Channel.Withdraw(d);
        }
        
        public System.Threading.Tasks.Task WithdrawAsync(double d) {
            return base.Channel.WithdrawAsync(d);
        }
        
        public double ShowInDinars() {
            return base.Channel.ShowInDinars();
        }
        
        public System.Threading.Tasks.Task<double> ShowInDinarsAsync() {
            return base.Channel.ShowInDinarsAsync();
        }
    }
}