using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using StackOverflow.Wcf.Services;

namespace StackOverflow.Wcf.WcfServiceHostManagers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ClientConnectionService)))
            {
                host.Open();
                Console.WriteLine($"{host.Description.Name} is up and listening on the URI given below. Press <enter> to exit.");
                PrintServiceInfo(host.Description);
                Console.ReadLine();
            }
        }

        private static void PrintServiceInfo(ServiceDescription desc)
        {
            foreach (ServiceEndpoint nextEndpoint in desc.Endpoints)
            {
                Console.WriteLine(nextEndpoint.Address);
            }
            
        }
    }
}
