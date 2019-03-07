using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word
{
    class MyWord // класс для хранения слова и его повторов
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public MyWord(string word)
        {
            Word = word;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("INPUT.txt",Encoding.Default); // создаем поток

            string s = streamReader.ReadToEnd(); // считываем текст в строку
            s = s.ToUpper(); // меняем все на верхний регистр
            string[] sS = s.Split(' ', '\n', '\r', ',', '.', '?', '!'); // разбиваем строку на слова 
            string[] ssDistinct = sS.Distinct().ToArray(); // получаем строку с уникальными (не повторяющимися) словами

            MyWord[] myWords = new MyWord[ssDistinct.Length]; // массив объектов для хранения слова и его повторов

            for(int i = 0; i < ssDistinct.Length; i++)
            {
                myWords[i] = new MyWord(ssDistinct[i]); // создаем объект слово

                for(int j = 0; j < sS.Length; j++)
                {
                    if(ssDistinct[i] == sS[j]) // если уникальное слово встречается в тексте, то увеличиваем счетчик
                    {
                        myWords[i].Count++;
                    }
                }
            }

            
            foreach(MyWord mW in Max(myWords)) // выводим список частых слов
            {
                Console.WriteLine("Частое слово: {0}", mW.Word);
                Console.WriteLine("Количество повторов: {0}", mW.Count);
            }
            Console.ReadKey();
        }

        static List<MyWord> Max(MyWord[] myWords)
        {
            int max = 0;
            MyWord myWord = new MyWord(myWords[0].Word); // задаем начальное слово
            List<MyWord> wordsMax = new List<MyWord>(); // список слов на случай если частых слов будет несколько
            myWord.Count = myWords[0].Count; // задаем начальное количество повторов
            wordsMax.Add(myWord); // добавляем в список первое слово

            for (int i = 0; i < myWords.Length; i++)
            {
                if (myWords[i].Count > max)
                {
                    wordsMax.Clear(); // очищаем список если количество повторов больше максимального
                    max = myWords[i].Count; // новое значение максимума
                    myWord.Word = myWords[i].Word; // запоминаем слово
                    myWord.Count = myWords[i].Count; // запоминаем количество повторов
                    wordsMax.Add(myWord); // добовляем слово
                }
                else if(myWords[i].Count == max) // если встретилось слово с таким же количеством повторов
                {
                    MyWord newMyWord = new MyWord(myWords[i].Word); // создаем объект этого слова
                    newMyWord.Count = myWords[i].Count; // записываем его количество повторов
                    wordsMax.Add(newMyWord); // добавляем его в список
                }
            }

            return wordsMax; //возвращаем список
        }
    }
}
