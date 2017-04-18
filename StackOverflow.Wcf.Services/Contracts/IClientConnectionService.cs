using System.ServiceModel;

namespace StackOverflow.Wcf.Services.Contracts
{
    [ServiceContract]
    public interface IClientConnectionService
    {
        [OperationContract]
        bool Connect(string message);
    }
}