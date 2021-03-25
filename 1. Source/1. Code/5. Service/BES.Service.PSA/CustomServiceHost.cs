using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace BES.Service.PSA
{
    public class CustomServiceHost
        : ServiceHostFactory
    {
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            //throw new Exception("I'm Here");
            return base.CreateServiceHost(constructorString, baseAddresses);
        }

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            //throw new Exception("I'm Here");
            return base.CreateServiceHost(serviceType, baseAddresses);
        }
    }
}