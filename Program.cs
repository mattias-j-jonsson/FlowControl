using System;
using System.Threading;

namespace FlowControl
{
    internal class Program
    {

        int calculateTicketPrice(int age)
        {
            return 0;
        }
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
                Console.WriteLine("1. Ticket information");
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
                        if(numberOfCustomers == 1)
                        {
                            Console.Write("Age (in digits): ");
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
                        } else
                        {
                            int totalSum = 0;
                            for(int i = 0; i < numberOfCustomers; i++)
                            {
                                Console.Write($"Age of guest {i+1} (in digits): ");
                                string? ageStr = Console.ReadLine();
                                int age;
                                if(int.TryParse(ageStr, out age))
                                {
                                    if(age < 20)
                                    {
                                        totalSum += 80;
                                    } else if(age > 64)
                                    {
                                        totalSum += 90;
                                    } else
                                    {
                                        totalSum += 120;
                                    }
                                } else
                                {
                                    Console.WriteLine("Error. Could not parse age");
                                    totalSum = -1;
                                    break;
                                }
                            }
                            if (totalSum > 0)
                            {
                                Thread.Sleep(500);
                                Console.WriteLine($"Total cost of tickets is {totalSum} kr");
                            }
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