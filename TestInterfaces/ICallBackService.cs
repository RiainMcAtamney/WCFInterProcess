using System.ServiceModel;

namespace TestInterfaces
{
    public interface ICallbackService
    {
        [OperationContract(IsOneWay = true)]
        void SendCallbackMessage(string message);
    }
}
