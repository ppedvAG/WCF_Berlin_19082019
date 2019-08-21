using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WCF_REST.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WCF REST Autos Brumm Brumm ***");

            var host = new ServiceHost(typeof(AutoService));

            host.AddServiceEndpoint(typeof(IAutoService), new NetTcpBinding(), "net.tcp://localhost:1");

            var webHttp = new WebHttpBinding();
            var ep = host.AddServiceEndpoint(typeof(IAutoService), webHttp, "http://localhost:2");
            var whb = new WebHttpBehavior() { AutomaticFormatSelectionEnabled = true };
            ep.EndpointBehaviors.Add(whb);


            host.Open();
            Console.WriteLine("Service gestartet");
            Console.ReadLine();
            host.Close();

            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }



}
