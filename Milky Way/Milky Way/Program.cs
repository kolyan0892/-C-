using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milky_Way
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // количество строк и столбцов
            int number; // число в таблице
            int sum = 0; // сумма соединений городов
            string[] sS;
            StreamReader fileIn = null;
            StreamWriter fileOut = null;

            try
            {
                fileIn = new StreamReader("INPUT.txt");
                fileOut = new StreamWriter("OUTPUT.txt", false);

                string s = fileIn.ReadLine(); // считываем количество строк и столбцов
                n = Int32.Parse(s);

                for (int i = 0; i < n; i++)
                {
                    s = fileIn.ReadLine(); // берем строку
                    sS = s.Split(' '); // разбиваем строку на цифры
                    for (int j = 0; j < n; j++)
                    {
                        number = Int32.Parse(sS[j]);
                        if (number > 0)
                        {
                            sum += 1;
                        }
                    }
                }

                fileOut.WriteLine(sum / 2); // записываем половину суммы. Количество дорог из города и в город равно 1 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(fileIn != null)
                    fileIn.Close();

                if(fileOut != null)
                    fileOut.Close();

                Console.WriteLine("Нажмите любую клавишу для завершения программы");
                Console.ReadKey();
            }            
        }
    }
}
