using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше выражение: ");
            string myOps = Console.ReadLine();
            Console.WriteLine("Ваше выражение: " + myOps);
        }
    }
}