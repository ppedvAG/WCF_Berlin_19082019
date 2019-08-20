using SelfHost.Contracts;
using System;
using System.ServiceModel;

namespace SelfHost.Host
{
    public class WetterService : IWetterService
    {
        public double GetTemperatur(string ort)
        {
            if (string.IsNullOrWhiteSpace(ort))
                throw new FaultException<OrtErrorInfo>(new OrtErrorInfo() { Info = "Der Ort muss angegeben werden!" },"Weil isso!");

            return new Random().NextDouble() * 20;
        }
    }
}
