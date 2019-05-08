using BLL;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Helper;

namespace Server.BLL
{
    public class Server
    {
        private object semaphore = new object();
        List<Socket> listClients = new List<Socket>();
        private bool running = true;
        private IPAddress iPAddress;
        private IPEndPoint iPEndPoint;
        private Socket serverSocket;
        private Thread acceptThread;
        private Thread recieveThread;
        private Thread sendThread;

        public Server()
        {
            InitializeServer();
            StartServer();
        }

        private void InitializeServer()
        {
            iPAddress = IPAddress.Parse(Changeables.ipNetwork);
            iPEndPoint = new IPEndPoint(iPAddress, Changeables.portNumber);

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void StartServer()
        {
            serverSocket.Bind(iPEndPoint);
            serverSocket.Listen(10);

            acceptThread = new Thread(() => AcceptConnection());
            acceptThread.Start();
        }

        private void AcceptConnection()
        {
            while (running)
            {
                lock (semaphore)
                {
                    Socket client = serverSocket.Accept();
                    listClients.Add(client);

                    recieveThread = new Thread(() => RecieveClientData(client));
                    recieveThread.Start();
                }
            }
        }

        private void RecieveClientData(Socket clientSocket)
        {
            while (running)
            {
                byte[] dataRecieved = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.Receive(dataRecieved);

                MessageObject message = (MessageObject)dataRecieved.BinaryDeserialize();

                ServerActions(message);
            }
        }

        public void StopServer()
        {
            running = false;
            sendThread.Abort();
            recieveThread.Abort();
            acceptThread.Abort();

            Thread.Sleep(10000);

            serverSocket.Shutdown(SocketShutdown.Both);
            serverSocket.Close();
        }

        public void SendData(Socket clientSocket, MessageObject message)
        {
            sendThread = new Thread(() => {
                byte[] dataToSend = message.BinarySerialize();
                clientSocket.Send(dataToSend);
            });

            sendThread.Start();
        }

        private void ServerActions(MessageObject message, Socket clientSocket = null)
        {
            
        }
    }
}
