using System;
using System.Text;

namespace Z_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string sentence = Console.ReadLine().ToLower();
            string alfavit = "аоуыэяёюие";
            foreach (var i in alfavit) sentence = sentence.Replace(i, '*');
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
