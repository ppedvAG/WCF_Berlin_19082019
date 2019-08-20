using SelfHost.Contracts;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHost.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WCF Host ***");

            var host = new ServiceHost(typeof(WetterService));

            host.AddServiceEndpoint(typeof(IWetterService), new NetTcpBinding(), "net.tcp://localhost:1");
            //host.AddServiceEndpoint(typeof(IWetterService), new BasicHttpBinding(), "http://localhost:3");
            //host.AddServiceEndpoint(typeof(IWetterService), new WSHttpBinding(), "http://localhost:4");
            host.AddServiceEndpoint(typeof(IWetterService), new NetNamedPipeBinding(), "net.pipe://localhost");

            //var smb = new ServiceMetadataBehavior()
            //{ HttpGetEnabled = true, HttpGetUrl = new Uri("http://localhost:2/mex") };
            //host.Description.Behaviors.Add(smb);
            
            host.Open();
            Console.WriteLine("Host gestartet");
            Console.ReadKey();
            host.Close();

            Console.WriteLine("Ende");
            Console.ReadKey();
        }
    }
}
