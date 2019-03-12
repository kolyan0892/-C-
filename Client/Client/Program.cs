using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.ServiceProcess;

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
            ServiceController[] scServices;
            string message;
            byte[] data;
            int cmd;
            int numberService;

            try
            {
                tcpClient = new TcpClient(address, port);
                networkStream = tcpClient.GetStream();

                while (true)
                {
                    scServices = ServiceController.GetServices();// получаем список всех служб

                    // получаем ответ
                    data = new byte[128]; // буфер для получаемых данных
                    StringBuilder stringBuilder = new StringBuilder();
                    int bytes = 0;

                    do
                    {
                        bytes = networkStream.Read(data, 0, data.Length); // считываем ответ
                        stringBuilder.Append(Encoding.Unicode.GetString(data, 0, bytes)); // декодируем байты в строку
                    }
                    while (networkStream.DataAvailable); // проверка на наличие данных в потоке 

                    message = stringBuilder.ToString(); // преобразуем в строку
                    Console.WriteLine("Команда сервера: {0}", message);

                    string[] messageSplit = message.Split(' '); // разбиваем команду по пробелам

                    cmd = Int32.Parse(messageSplit[0]);

                    if (messageSplit.Length == 2)
                    {
                        numberService = Int32.Parse(messageSplit[1]);
                        if (numberService < 0 || numberService > scServices.Length) // если введен не корректный номер службы
                        {
                            message = "Данная служба не найдена";
                        }
                        else
                        {
                            if (cmd == 0)
                            {
                                message = StopService(scServices[numberService].DisplayName); // останавливаем службу
                            }
                            else if (cmd == 1)
                            {
                                message = StartService(scServices[numberService].DisplayName); // запускаем службу
                            }
                            else if (cmd == 3)
                            {
                                message = StatusService(scServices[numberService].DisplayName); // информация о статусе службы
                            }
                        }
                    }

                    if (cmd == 2)
                    {
                        message = GetServices(networkStream, data, scServices); // выводим список служб
                    }
                    data = Encoding.Unicode.GetBytes(message); // преобразуем сообщение в массив байтов                    
                    networkStream.Write(data, 0, data.Length); // отправка сообщения
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

        private static string StartService(string serviceName) // запуск службы
        {
            ServiceController serviceController = new ServiceController(serviceName);

            if (serviceController.Status != ServiceControllerStatus.Running) // проверяем не запущенна ли служба
            {
                serviceController.Start(); // запускаем службу
                serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1)); // в течении минуты ждём статус от службы
                Console.WriteLine("Служба {0} запущена", serviceName);
                return "Служба запущена";
            }
            else // если служба уже запущена
            {
                return "Служба уже запущена";
            }
        }

        private static string StopService(string serviceName) // остановка службы
        {
            ServiceController serviceController = new ServiceController(serviceName);

            if (serviceController.Status != ServiceControllerStatus.Stopped) // проверяем не остановлена ли служба
            {
                serviceController.Stop(); // останавливаем службу
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1)); // в течении минуты ждём статус от службы
                Console.WriteLine("Служба {0} остановлена", serviceName);
                return "Служба остановлена";
            }
            else // если служба уже остановлена
            {
                return "Служба уже остановлена";
            }
        }

        private static string GetServices(NetworkStream networkStream, byte[] data, ServiceController[] scServices) // выводим ифнормацию о статусе каждой службы
        {
            string[] servicesName = new string[scServices.Length];
            string s = "";

            for (int i = 0; i < scServices.Length; i++)
            {
                servicesName[i] = scServices[i].DisplayName;
                s += String.Format("{0} : {1} статус службы : {2} \n", i, servicesName[i], scServices[i].Status);

            }
            return s;
        }

        private static string StatusService(string serviceName) // выводим ифнормацию о статусе каждой службы
        {
            ServiceController serviceController = new ServiceController(serviceName);

            return String.Format("{0} статус службы : {1} \n", serviceName, serviceController.Status);
        }
    }
}
