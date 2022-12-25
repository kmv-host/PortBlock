using System.Net.Sockets;
using System.Net;

namespace PortBlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int portToBlock = 999;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, portToBlock);
            s.Bind(ep);
        }
    }
}