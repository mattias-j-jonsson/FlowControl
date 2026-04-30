using System;
using System.Threading;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] argv)
        {
            bool running = true;
            while (running)
            {

                Console.WriteLine("");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Welcome to the Super Cinematic Cinema interactive age verification virtual experience!");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Please use 0-9 to navigate");
                Console.WriteLine("\n");
                Console.WriteLine("1. Enter age");
                Console.WriteLine("0. Quit");
                Console.WriteLine("");


                Console.Write("Input: ");
                string? input = Console.ReadLine();

                Thread.Sleep(500);
                switch (input)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.Write("How many are going to the movie? ");
                        string? numberOfCustomersStr = Console.ReadLine();
                        int numberOfCustomers;
                        bool correctGuestCount = int.TryParse(numberOfCustomersStr, out numberOfCustomers);
                        Thread.Sleep(500);
                        if(!correctGuestCount || numberOfCustomers < 1) // works because does not evakuate second condition if correctGuestCount is null
                        {
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(800);
                            break;
                        }
                        Console.Write("Input age (in digits): ");
                        string? ageStr = Console.ReadLine();
                        int age;
                        Thread.Sleep(500);
                        if(int.TryParse(ageStr, out age))
                        {
                            if(age < 20)
                            {
                                Console.WriteLine("Youth Ticket 80 kr");
                            } else if(age > 64)
                            {
                                Console.WriteLine("Senior Ticket 90 kr");
                            } else
                            {
                                Console.WriteLine("Standard Ticket 120 kr");
                            }
                        } else
                        {
                            Console.WriteLine("Please use only digits!");
                        }
                        Thread.Sleep(800);
                        break;
                    case "0":
                        Console.WriteLine("Thanks for participating.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Do better. Be better");
                        Thread.Sleep(800);
                        break;
                }
            }
        }
    }
}