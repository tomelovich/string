using System;

namespace Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string sentence = Console.ReadLine();
            sentence = sentence.Replace("Z", "Zz");
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
