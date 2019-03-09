using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Server
{
    public class ClientObject
    {
        public TcpClient client;
        bool statusService = false;

        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                while (true)
                {
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length); // считаываем ответ
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes)); // декодируем байты в строку
                    }
                    while (stream.DataAvailable); // проверка на наличие данных в потоке

                    string message = builder.ToString(); // преобразуем в строку

                    Console.WriteLine(message);
                    message = Service(message); // возвращает статус службы
                    data = Encoding.Unicode.GetBytes(message); // кодируем сообщение в байты
                    stream.Write(data, 0, data.Length); // отправляем сообщение
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }

        private string Service(string message) // для возврата статуса службы
        {
            int cmd = Int32.Parse(message);
            if(cmd == 1 && !statusService) // если пришла команда включить и служба отключена
            {
                statusService = true;
                return "Запуск службы";             
            }
            else if (cmd == 1 && statusService) // если пришла команда включить и служба включена
            {
                return "Служба уже в работе";
            }
            else if(cmd == 0 && statusService) // если пришла команда отключить и служба включена
            {
                statusService = false;
                return "Остановка службы";
            }
            else // если пришла команда отключить и служба отключена
            {
                return "Служба уже остановлена";
            }
        }
    }
}
