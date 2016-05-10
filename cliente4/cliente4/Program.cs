/* program.cs
 * Descripción:
 * Cliente con protocolo TCP.
 * Recibe un dato typo byte[] del servidor, lo convierte en tipo ulong y lo despliega en pantalla.
 * Fecha: 28 de enero de 2015
 * Versión 1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace sclient
{
    class Program
    {
        static void Main()
        {
            TcpClient client = null;
            NetworkStream stream = null;

            try
            {
                Int32 port = 4444;
                String localAddr = "201.174.25.130";
                //String localAddr = "192.168.1.151"; 
                client = new TcpClient(localAddr, port);
                // Buffer to store the response bytes.
                Byte[] data = new Byte[512];
                Console.WriteLine("Conectando con el servidor...");

                // Get a client stream for reading.
                stream = client.GetStream();
                
                // String to store the response ASCII representation.
                //String responseData = String.Empty;
                int i = 0;
                while (i < 5)
                {
                    // Read the first batch of the TcpServer response bytes.
                    stream.Read(data, 0, data.Length);
                    ulong datoUL = BitConverter.ToUInt64(data, 0);
                    Console.WriteLine("Received: " + datoUL);
                    i++;
                }

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch
            {
                Console.WriteLine("Error al conectar con el servidor");
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
    }
}
