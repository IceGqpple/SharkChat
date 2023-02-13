using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SharkChat
{
    public partial class Form1 : Form
    {
        //Socket sck;
        EndPoint epLocal, epRemote;
        Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ////sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), int.Parse(textLocalPort.Text));
            //sck.Bind(localEndPoint);//server ip
            //sck.Listen();
            textLocalIP.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
            //sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);

            buffer= new byte[1024];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1024];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            sck.Send(sendingMessage);

            listMessage.Items.Add("Me: " + textMessage.Text);
            textMessage.Text = "";
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void textLocalIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListenServer_Click(object sender, EventArgs e)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), int.Parse(textLocalPort.Text));
            sck.Bind(localEndPoint);//server ip
            sck.Listen(10);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                //Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                byte[] receivedData = new byte[1024];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                listMessage.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1024];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}