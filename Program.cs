using System;

namespace FlowControl
{
    internal class Program
    {
        static void Main (string[] argv)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Please use 0-9 to navigate");
            Console.WriteLine("\n");
            Console.WriteLine("0. Quit");
            Console.WriteLine("");
            Console.Write("Input: ");
            string? input = Console.ReadLine();
        }
    }
}