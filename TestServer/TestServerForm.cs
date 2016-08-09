using System;
using System.ServiceModel;
using System.Windows.Forms;
using TestInterfaces;

namespace TestServer
{
    public partial class TestServerForm : Form
    {
        public TestServerForm()
        {
            InitializeComponent();
        }

        private void TestServerForm_Load(object sender, EventArgs e)
        {
            var host = new ServiceHost(typeof(TestService),
                       new Uri("net.pipe://localhost"));

            host.AddServiceEndpoint(typeof(ITestService),
                                    new NetNamedPipeBinding(), "Test");
            host.Open();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            TestService.Callback.SendCallbackMessage("Hi, I'm the server");
        }
    }
}
