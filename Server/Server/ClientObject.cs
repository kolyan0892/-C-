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
        public TcpClient client;

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
                    message = Service(message, "Центр обновления Windows"); // запускаем/останавливаем службу, возвращаем статус службы
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

        private string Service(string message, string serviceName) // для возврата статуса службы
        {
            int cmd = Int32.Parse(message);

            if(cmd == 1) // если пришла команда включить и служба отключена
            {                
                return StartService(serviceName);             
            }
            else // если пришла команда отключить
            {
                return StopService(serviceName);
            }
        }

        private string StartService(string serviceName) // запуск службы
        {
            ServiceController serviceController = new ServiceController(serviceName);

            if(serviceController.Status != ServiceControllerStatus.Running) // проверяем не запущенна ли служба
            {
                serviceController.Start(); // запускаем службу
                serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1)); // в течении минуты ждём статус от службы
                return "Служба запущена";
            }
            else // если служба уже запущена
            {
                return "Служба уже запущена";
            }
        }

        private string StopService(string serviceName) // запуск службы
        {
            ServiceController serviceController = new ServiceController(serviceName);

            if (serviceController.Status != ServiceControllerStatus.Stopped) // проверяем не остановлена ли служба
            {
                serviceController.Stop(); // останавливаем службу
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1)); // в течении минуты ждём статус от службы
                return "Служба остановлена";
            }
            else // если служба уже остановлена
            {
                return "Служба уже остановлена";
            }
        }
    }
}
