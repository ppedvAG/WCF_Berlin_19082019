using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfChat2000.Contracts;

namespace WcfChat2000.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WCF Chat Server 2000 ***");

            var tcpBind = new NetTcpBinding();
            tcpBind.MaxReceivedMessageSize = int.MaxValue;

            ServiceHost host = new ServiceHost(typeof(WcfChat2000Server));
            host.AddServiceEndpoint(typeof(IServer), tcpBind, "net.tcp://localhost:1");
            host.Open();
            Console.WriteLine("Server wurde gestartet");
            Console.ReadLine();
            host.Close();
            Console.WriteLine("Server wurde beendet");
            Console.WriteLine("Ende");
            Console.ReadKey();
        }
    }
}
