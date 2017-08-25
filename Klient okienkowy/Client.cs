using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Klient_okienkowy
{
    public class Client
    {
        public static NetworkStream stream;
        public static TcpClient client;
        public static string hostname = "172.17.1.168";
        public static Int32 port = 13000;


        public static string Connect(TcpClient client, String server, String message)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                stream = client.GetStream();
                stream.Flush();
                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);
                return responseData;
                // Close everything.
                //stream.Close();
                //client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
                return "Ponow wiadomosc";
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                return "Ponow wiadomosc";
            }
            catch (System.ObjectDisposedException)
            {
                return "Ponow wiadomosc";
            }

            //Console.WriteLine("\n Press Enter to continue...");
            //Console.Read();
        }
    }
}
