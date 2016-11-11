using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//new ones
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace Lab1
{
    public partial class Form1 : Form
    {

        Socket connectionSocket;
        EndPoint epLocal, epRemote;
        string myName, remoteName;
        bool firstMessage = true;
        byte[] buffer;



        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) //it will run before UI is drawn
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;

            myIPBox.Text = GetMyIP();
            targetIPBox.Text = GetMyIP();

            connectionSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            connectionSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


        }

        private string GetMyIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            return "127.0.0.1";
        }

        private void connect_Click(object sender, EventArgs e)
        {
            myName = username.Text;
            buffer = new byte[1500];

            epLocal = new IPEndPoint(IPAddress.Parse(myIPBox.Text), (int)myPort.Value);
            connectionSocket.Bind(epLocal); // my connection is binding

            epRemote = new IPEndPoint(IPAddress.Parse(targetIPBox.Text), (int)targetPort.Value);
            connectionSocket.Connect(epRemote); // i 'connect' to target
            connectionSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            ASCIIEncoding aEncoder = new ASCIIEncoding();
            byte[] sendMsg = aEncoder.GetBytes("$" + myName + "#");
            Thread.Sleep(3000);
            connectionSocket.Send(sendMsg);



        }

        private void send_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoder = new ASCIIEncoding();
            byte[] sendMsg = aEncoder.GetBytes(newInputBox.Text);

            connectionSocket.Send(sendMsg);

            StringBuilder builder = new StringBuilder();
            builder.Append(">>> " + myName + ": ");
            builder.Append(newInputBox.Text);

            chatHistory.Items.Add(builder.ToString());
            newInputBox.Clear();
        }


        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {

                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                buffer = new byte[1500];
                ASCIIEncoding aEncoder = new ASCIIEncoding();
                String receivedString = aEncoder.GetString(receivedData);

                if (receivedString.Contains("$") && receivedString.Contains("#"))
                {
                    remoteName = receivedString.Substring(receivedString.IndexOf('$')+1, receivedString.IndexOf('#') - receivedString.IndexOf('$')-1);
                    connectionSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                    return;
                }

                StringBuilder builder = new StringBuilder();
                builder.Append(">>> " + remoteName + ": ");
                builder.Append(receivedString);

                chatHistory.Items.Add(builder.ToString());
                connectionSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in incoming text!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






    }
}
