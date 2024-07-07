using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textInString = "Дана строка с текстом, используя метод строки String.Split() " +
                "получить массив слов, которые разделены пробелом в тексте и " +
                "вывести массив, каждое слово с новой строки.";

            char[] separator = new char[] { ',', ' ', '.' };

            string[] subString = textInString.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in subString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
