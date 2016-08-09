using System;
using System.ServiceModel;
using System.Windows.Forms;
using TestInterfaces;

namespace TestClient
{
    public partial class TestClientForm : Form
    {
        ITestService service;

        public TestClientForm()
        {
            InitializeComponent();
        }

        public void TestClientForm_Load(object sender, EventArgs e)
        {
            var callback = new TestCallback();
            var context = new InstanceContext(callback);
            var pipeFactory =
                 new DuplexChannelFactory<ITestService>(context,
                 new NetNamedPipeBinding(),
                 new EndpointAddress("net.pipe://localhost/Test"));

            service = pipeFactory.CreateChannel();

            service.Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            service.SendMessage("Hi, I'm the client");
        }
    }
}
