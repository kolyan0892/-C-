using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader("INPUT.txt", Encoding.Default); // создаем поток

                string s = streamReader.ReadToEnd(); // считываем текст в строку
                s = s.ToUpper(); // меняем все на верхний регистр
                string[] sS = s.Split(' ', '\n', '\r', ',', '.', '?', '!'); // разбиваем строку на слова 
                string[] ssDistinct = sS.Distinct().ToArray(); // получаем строку с уникальными (не повторяющимися) словами

                WordStorage[] wordsStorage = new WordStorage[ssDistinct.Length]; // массив объектов для хранения слова и его повторов

                for (int i = 0; i < ssDistinct.Length; i++)
                {
                    wordsStorage[i] = new WordStorage(ssDistinct[i]); // создаем объект слово

                    for (int j = 0; j < sS.Length; j++)
                    {
                        if (ssDistinct[i] == sS[j]) // если уникальное слово встречается в тексте, то увеличиваем счетчик
                        {
                            wordsStorage[i].Count++;
                        }
                    }
                }

                foreach (WordStorage mW in Max(wordsStorage)) // выводим список частых слов
                {
                    Console.WriteLine("Частое слово: {0}", mW.Word);
                    Console.WriteLine("Количество повторов: {0}", mW.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();

                Console.WriteLine("Нажмите любую клавишу для завершения программы");
                Console.ReadKey();
            }
            
        }

        static List<WordStorage> Max(WordStorage[] wordsStorage)
        {
            int max = 0;
            WordStorage wordStorage = new WordStorage(wordsStorage[0].Word); // задаем начальное слово
            wordStorage.Count = wordsStorage[0].Count; // задаем начальное количество повторов
            List<WordStorage> wordsMax = new List<WordStorage>(); // список слов на случай если частых слов будет несколько
             
            wordsMax.Add(wordStorage); // добавляем в список первое слово

            for (int i = 0; i < wordsStorage.Length; i++)
            {
                if (wordsStorage[i].Count > max)
                {
                    wordsMax.Clear(); // очищаем список если количество повторов больше максимального
                    max = wordsStorage[i].Count; // новое значение максимума
                    wordStorage.Word = wordsStorage[i].Word; // запоминаем слово
                    wordStorage.Count = wordsStorage[i].Count; // запоминаем количество повторов
                    wordsMax.Add(wordStorage); // добавляем слово
                }
                else if(wordsStorage[i].Count == max) // если встретилось слово с таким же количеством повторов
                {
                    WordStorage newMyWord = new WordStorage(wordsStorage[i].Word); // создаем объект этого слова
                    newMyWord.Count = wordsStorage[i].Count; // записываем его количество повторов
                    wordsMax.Add(newMyWord); // добавляем его в список
                }
            }

            return wordsMax; //возвращаем список
        }
    }
}
