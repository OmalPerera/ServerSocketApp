using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSocketApp
{
    public partial class Form_Server_Socket : Form
    {


        SocketPermission permission;
        Socket sListener;
        IPEndPoint ipEndPoint;
        Socket handler;

        private TextBox tbAux = new TextBox();




        public Form_Server_Socket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.PortName = "COM8";
            serialPort.Open();
            serialPort.BaudRate = 200;

        }

        private void btn_conct_server_Click(object sender, EventArgs e)
        {
            start_the_server();
        }

        private void btn_start_listen_Click(object sender, EventArgs e)
        {
            listning_mode();
        }


        private void start_the_server()
        {
            try
            {
                // Creates one SocketPermission object for access restrictions
                permission = new SocketPermission(
                NetworkAccess.Accept,     // Allowed to accept connections 
                TransportType.Tcp,        // Defines transport types 
                "",                       // The IP addresses of local host 
                SocketPermission.AllPorts // Specifies all ports 
                );

                // Listening Socket object 
                sListener = null;

                // Ensures the code to have permission to access a Socket 
                permission.Demand();

                // Resolves a host name to an IPHostEntry instance 
                IPHostEntry ipHost = Dns.GetHostEntry("");

                // Gets first IP address associated with a localhost 
                IPAddress ipAddr = ipHost.AddressList[0];

                // Creates a network endpoint 
                ipEndPoint = new IPEndPoint(ipAddr, 4610);

                // Create one Socket object to listen the incoming connection 
                sListener = new Socket(
                    ipAddr.AddressFamily,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                // Associates a Socket with a local endpoint 
                sListener.Bind(ipEndPoint);

                lbl_server_status.Text = "Server started Successfully.";
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void listning_mode()
        {
            try
            {
                // Places a Socket in a listening state and specifies the maximum 
                // Length of the pending connections queue 
                sListener.Listen(10);

                // Begins an asynchronous operation to accept an attempt 
                AsyncCallback aCallback = new AsyncCallback(AcceptCallback);
                sListener.BeginAccept(aCallback, sListener);

                lbl_server_status.Text = "Server is listening on " + ipEndPoint.Address + " port: " + ipEndPoint.Port;


                //Send_Button.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }

        }


        public void AcceptCallback(IAsyncResult ar)
        {
            Socket listener = null;

            // A new Socket to handle remote host communication 
            Socket handler = null;
            try
            {
                // Receiving byte array 
                byte[] buffer = new byte[1024];
                // Get Listening Socket object 
                listener = (Socket)ar.AsyncState;
                // Create a new socket 
                handler = listener.EndAccept(ar);

                // Using the Nagle algorithm 
                handler.NoDelay = false;

                // Creates one object array for passing data 
                object[] obj = new object[2];
                obj[0] = buffer;
                obj[1] = handler;

                // Begins to asynchronously receive data 
                handler.BeginReceive(
                    buffer,        // An array of type Byt for received data 
                    0,             // The zero-based position in the buffer  
                    buffer.Length, // The number of bytes to receive 
                    SocketFlags.None,// Specifies send and receive behaviors 
                    new AsyncCallback(ReceiveCallback),//An AsyncCallback delegate 
                    obj            // Specifies infomation for receive operation 
                    );

                // Begins an asynchronous operation to accept an attempt 
                AsyncCallback aCallback = new AsyncCallback(AcceptCallback);
                listener.BeginAccept(aCallback, listener);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }


        string content = string.Empty;
        string str = string.Empty;
        public void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Fetch a user-defined object that contains information 
                object[] obj = new object[2];
                obj = (object[])ar.AsyncState;

                // Received byte array 
                byte[] buffer = (byte[])obj[0];

                // A Socket to handle remote host communication. 
                handler = (Socket)obj[1];

                // Received message 
                //string content = string.Empty;


                // The number of bytes received. 
                int bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                {
                    content += Encoding.Unicode.GetString(buffer, 0,
                        bytesRead);

                    // If message contains "<Client Quit>", finish receiving
                    if (content.IndexOf("<Client Quit>") > -1)
                    {
                        // Convert byte array to string
                        string str = content.Substring(0, content.LastIndexOf("<Client Quit>"));

                        //this is used because the UI couldn't be accessed from an external Thread
                        this.BeginInvoke(new InvokeDelegate(HandleSelection_2));
                         
                    }
                    else
                    {
                        // Continues to asynchronously receive data
                        byte[] buffernew = new byte[1024];
                        obj[0] = buffernew;
                        obj[1] = handler;
                        handler.BeginReceive(buffernew, 0, buffernew.Length,
                            SocketFlags.None,
                            new AsyncCallback(ReceiveCallback), obj);
                    }

                    this.BeginInvoke(new InvokeDelegate(HandleSelection_1)); 
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        public void HandleSelection_1()
        {
            //showing the message fron the client
            lbl_server_msg_show.Text = "";
            lbl_server_msg_show.Text = content;

            serialPort.Write(lbl_server_msg_show.Text);

        }

        public void HandleSelection_2()
        {
            tbAux.Text = "Read " + str.Length * 2 + " bytes from client.\n Data: " + str;
        }

        public void SendCallback(IAsyncResult ar)
        {

            try
            {
                // A Socket which has sent the data to remote host 
                Socket handler = (Socket)ar.AsyncState;

                // The number of bytes sent to the Socket 
                int bytesSend = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to Client", bytesSend);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }

        }


        public delegate void InvokeDelegate();
        private void tbAux_SelectionChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new InvokeDelegate(HandleSelection));
        }

        private void HandleSelection()
        {
                lbl_server_msg_show.Text = tbAux.Text;
        }
   
}
}
