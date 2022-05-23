using System;

namespace Z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int g = words.Length-1;
            words[0] = words[0].Substring(2);
            string r = words[0];
            words[0] = words[g];
            words[g] = r;
            string two_three = words[1] + words[2];
            string rez = words[0] + " " + words[g];
            Console.WriteLine("Удалены первые две буквы - {0}",r);
            Console.WriteLine("Второе и третье сообщения склеены - {0}", two_three);
            Console.WriteLine(rez);
        }
    }
}
