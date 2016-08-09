using System.ServiceModel;


namespace TestInterfaces
{
    [ServiceContract(SessionMode = SessionMode.Required,
    CallbackContract = typeof(ICallbackService))]
    public interface ITestService
    {
        [OperationContract(IsOneWay = true)]
        void Connect();

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }
}
