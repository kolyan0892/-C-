using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        const int port = 8888; // номер порта
        const string address = "127.0.0.1"; // IP адрес
        static void Main(string[] args)
        {
            TcpClient tcpClient = null;
            NetworkStream networkStream = null;
            try
            {
                tcpClient = new TcpClient(address, port);
                networkStream = tcpClient.GetStream();

                while (true)
                {
                    Console.WriteLine("Введите команду: 0 - отключить службу, 1 - включить службу");
                    string message = Console.ReadLine(); // ввод команды

                    try
                    {
                        int cmd = Int32.Parse(message);
                        if(cmd != 1 && cmd != 0)
                        {
                            Console.WriteLine("Введена неверная команда");
                            continue;
                        }
                    }
                    catch (FormatException) // если введено что-то не то
                    {
                        Console.WriteLine("Введена неверная команда");
                        continue;
                    }
                   
                    byte[] data = Encoding.Unicode.GetBytes(message); // преобразуем сообщение в массив байтов                    
                    networkStream.Write(data, 0, data.Length); // отправка сообщения

                    // получаем ответ
                    data = new byte[64]; // буфер для получаемых данных
                    StringBuilder stringBuilder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = networkStream.Read(data, 0, data.Length); // считываем ответ
                        stringBuilder.Append(Encoding.Unicode.GetString(data, 0, bytes)); // декодируем байты в строку
                    }
                    while (networkStream.DataAvailable); // проверка на наличие данных в потоке 

                    message = stringBuilder.ToString(); // преобразуем в строку
                    Console.WriteLine("Сервер: {0}", message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Нажмите любую клавишу для завершения программы");
                Console.ReadKey();
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
