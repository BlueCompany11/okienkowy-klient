using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Klient_okienkowy
{
    public class Client
    {
        public static NetworkStream stream;
        public static TcpClient client;
        public static string hostname = "172.17.1.168";
        public static Int32 port = 13000;
        public static string recivedData;
        public static Byte[] bytes = new Byte[256];
        private readonly Form1 mainForm;

        public Client(Form1 x = null)
        {
            mainForm = x;
        }



        public static Action ReciveMessageAction = () =>
         {
             Client tempClient = new Client();
             while (true)
             {
                 if (stream != null)
                 {
                     Byte[] data = new Byte[256];
                     // String to store the response ASCII representation.
                     String responseData = String.Empty;
                     // Read the first batch of the TcpServer response bytes.

                     int i = stream.Read(bytes, 0, bytes.Length);
                     while (i != 0)
                     {
                         responseData = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                         Console.WriteLine("Received: {0}", responseData);
                         recivedData = responseData;
                         i = stream.Read(bytes, 0, bytes.Length);
                         if (!string.IsNullOrEmpty(recivedData))
                         {
                             //PlaceForText
                         }
                     }
                 }
                 //if (!string.IsNullOrEmpty(recivedData))
                 //tempClient.MessageArrived(recivedData, null);
             }
         };

        public event EventHandler OnChildTextChanged;
        private void MessageArrived(object sender, EventArgs e)
        {
            Console.WriteLine((string)sender);
            OnChildTextChanged?.Invoke((string)sender, null);
        }

        public static void Connect(TcpClient client, String server, String message)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                // Get a client stream for reading and writing.
                stream = client.GetStream();
                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent 2: {0}", message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);

            }
            catch (SocketException e)
            {

            }
            catch (System.ObjectDisposedException)
            {

            }
            //Console.WriteLine("\n Press Enter to continue...");
            //Console.Read();
        }
    }
}
