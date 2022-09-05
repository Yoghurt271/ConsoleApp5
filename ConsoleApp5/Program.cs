using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Мама";
            if ((str.StartsWith("А")) ^ (str.EndsWith("а")))
            Console.Write("Слово начинается или заканчивается на букву А");
            else
            Console.Write("Слово не начинаеться и не заканчиватся на букву А");

        }
    }
}
