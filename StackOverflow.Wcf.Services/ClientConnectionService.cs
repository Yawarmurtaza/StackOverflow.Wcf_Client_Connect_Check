using StackOverflow.Wcf.Services.Contracts;

namespace StackOverflow.Wcf.Services
{
    public class ClientConnectionService : IClientConnectionService
    {
        public bool Connect(string message)
        {
            /*
             * As per your comment on http://stackoverflow.com/questions/43366101/how-to-check-wcf-service-is-connected-with-client?noredirect=1#comment74005120_43366101
             * the message should be empty, however you can pass string.
             * Once you are done with processing you can return true or false depending upon how you want to carry out 
             * this operation.
             */
            return true;
        }
    }
}