using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using StackOverflow.Wcf.Services.Contracts;

namespace StackOverflow.Wcf.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ClientConnectionServiceProxy proxy = new ClientConnectionServiceProxy())
            {
                bool isCallSuccessful = proxy.Connect(string.Empty);
            }
        }
    }

    public class ClientConnectionServiceProxy : ClientBase<IClientConnectionService>
    {
        public bool Connect(string message)
        {
            return base.Channel.Connect(message);
        }
    }
}
