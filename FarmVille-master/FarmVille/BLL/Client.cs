using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Helper;
using BLL;

namespace FarmVille.BLL
{
    public class Client
    {
        private object semaphore = new object();
        private bool runningState = true;
        private IPAddress iPAddress;
        private IPEndPoint remoteIpEndpoint;
        private Socket clientSocket;
        private Thread recieveThread;
        private Thread sendThread;

        public Client()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            iPAddress = IPAddress.Parse(Changeables.ipNetwork);
            remoteIpEndpoint = new IPEndPoint(iPAddress, Changeables.portNumber);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            StartServer();
        }

        private void StartServer()
        {
            clientSocket.Connect(remoteIpEndpoint);

            recieveThread = new Thread(() => RecieveData(clientSocket));
            recieveThread.Start();
        }

        private void RecieveData(Socket client)
        {
            while (runningState)
            {
                lock (semaphore)
                {
                    byte[] dataRecieved = new byte[client.ReceiveBufferSize];
                    client.Receive(dataRecieved);
                    MessageObject message = (MessageObject)dataRecieved.BinaryDeserialize();

                    ClientActions(message);
                }
            }
        }

        public void SendData(MessageObject message)
        {
            clientSocket.Send(message.BinarySerialize());
        }

        private void ClientActions(MessageObject message)
        {
            
        }
    }
}
