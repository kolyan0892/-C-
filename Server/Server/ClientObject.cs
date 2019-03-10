using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.ServiceProcess;

namespace Server
{
    public class ClientObject
    {
        public TcpClient tcpClient;
        string message;
        int cmd;
        bool parse;

        public ClientObject(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
        }

        public void Process()
        {
            NetworkStream networkStream = null;
            try
            {
                networkStream = tcpClient.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                while (true)
                {
                    Console.WriteLine("Введите команду: 0 - отключить службу, 1 - включить службу, 2 - получить список служб, 3 - получить статус конкретной службы");
                    message = Console.ReadLine(); // запускаем/останавливаем службу, возвращаем статус службы
                    parse = Int32.TryParse(message, out cmd);
                    
                    if (cmd < 0 || cmd > 3 || parse == false)
                    {
                        Console.WriteLine("Введена неверная команда");
                        continue;
                    }
                    else if (cmd == 0 || cmd == 1 || cmd == 3) // если необходимо указывать номер службы
                    {
                        Console.WriteLine("Введите номер службы \n");
                        message += " " + Console.ReadLine();
                    }

                    data = Encoding.Unicode.GetBytes(message); // кодируем сообщение в байты
                    networkStream.Write(data, 0, data.Length); // отправляем сообщение

                    // получаем сообщение
                    StringBuilder stringBuilder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = networkStream.Read(data, 0, data.Length); // считываем ответ
                        stringBuilder.Append(Encoding.Unicode.GetString(data, 0, bytes)); // декодируем байты в строку
                    }
                    while (networkStream.DataAvailable); // проверка на наличие данных в потоке

                    message = stringBuilder.ToString(); // преобразуем в строку  
                    Console.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (networkStream != null)
                    networkStream.Close();
                if (tcpClient != null)
                    tcpClient.Close();
            }
        }
    }
}
