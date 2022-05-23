using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Z_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string alf = "*АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            const string NUM = "0123456789";
            Console.Write("ФИО: ");
            string c2 = Console.ReadLine();
            var strHash = Hash(Regex.Replace(c2.ToUpper(), @"[^А-Я]", ""), alf);
            do
            {
                strHash = Hash(strHash, NUM);
            }
            while (strHash.Length > 1);

            Console.WriteLine(strHash);
            Console.ReadLine();
        }

        static string Hash(string str, string ABC)
        {
            return str.Select(ch => ABC.IndexOf(ch)).Aggregate(0, (acc, charValue) => acc + charValue).ToString();
        }
    }
}
