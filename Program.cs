using System;

namespace LengthString
{
    class Program
    {
        static void Main(string[] args)
        {
            Here:
            Console.Write("Input : ");
            var str = Console.ReadLine();
            Console.WriteLine($"Length is {str.Length}");
            goto Here;
        }
    }
}
