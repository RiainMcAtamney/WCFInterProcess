using System.Windows.Forms;
using TestInterfaces;

namespace TestClient
{
    public class TestCallback : ICallbackService
    {
        public void SendCallbackMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
