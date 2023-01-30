using System;
using System.Collections.Generic;
namespace Name_reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in your name to be reversed: ");
            var input = Console.ReadLine();

            var name = input.ToCharArray();
            Array.Reverse(name);
            var reversedname = string.Join("", name);

            Console.WriteLine(reversedname);
        }
    }
}
