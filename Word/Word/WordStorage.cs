using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    class WordStorage // класс для хранения слова и его повторов
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public WordStorage(string word)
        {
            Word = word;
        }
    }
}
