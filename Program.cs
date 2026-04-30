using System;
using System.Threading;
using System.Text;
using System.Linq;

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
                Console.WriteLine("2. Get repeated");
                Console.WriteLine("3. Word number 3");
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
                        if (!correctGuestCount || numberOfCustomers < 1) // works because does not evakuate second condition if correctGuestCount is null
                        {
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(800);
                            break;
                        }
                        if (numberOfCustomers == 1)
                        {
                            Console.Write("Age (in digits): ");
                            string? ageStr = Console.ReadLine();
                            int age;
                            Thread.Sleep(500);
                            if (int.TryParse(ageStr, out age))
                            {
                                if (age < 20)
                                {
                                    Console.WriteLine("Youth Ticket 80 kr");
                                }
                                else if (age > 64)
                                {
                                    Console.WriteLine("Senior Ticket 90 kr");
                                }
                                else
                                {
                                    Console.WriteLine("Standard Ticket 120 kr");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please use only digits!");
                            }
                        }
                        else
                        {
                            int totalSum = 0;
                            for (int i = 0; i < numberOfCustomers; i++)
                            {
                                Console.Write($"Age of guest {i + 1} (in digits): ");
                                string? ageStr = Console.ReadLine();
                                int age;
                                if (int.TryParse(ageStr, out age))
                                {
                                    if (age < 20)
                                    {
                                        totalSum += 80;
                                    }
                                    else if (age > 64)
                                    {
                                        totalSum += 90;
                                    }
                                    else
                                    {
                                        totalSum += 120;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error. Could not parse age");
                                    totalSum = -1; // this is to not output any previous "valid" calculations that was done befire the invalid input
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
                    case "2":
                        Console.Write("Say something and I will repeat it back to you 10 times: ");
                        string? inputToRepeat = Console.ReadLine();
                        Thread.Sleep(500);
                        // StringBuilder sb = new StringBuilder();
                        // for(int i = 0; i < 10; i++)
                        // {
                        //     sb.Append(i+1);
                        //     sb.Append(". ");
                        //     sb.Append(inputToRepeat);
                        //     sb.Append(" ");
                        // }
                        // Console.WriteLine(sb.ToString());
                        // Console.WriteLine();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write((i + 1) + ". " + inputToRepeat + " ");
                        }
                        Thread.Sleep(800);
                        break;
                    case "3":
                        Console.Write("Write a sentence with at least 3 words: ");
                        string? inputSentence = Console.ReadLine();
                        Thread.Sleep(500);
                        string[] splitSentence = inputSentence.Split(' ');
                        if (splitSentence.Length < 3)
                        {
                            Console.WriteLine("Too few words.");
                            break;
                        }
                        int numberOfWords = 0;
                        int indexOfThirdWord = 0;
                        while (indexOfThirdWord < splitSentence.Length)
                        {
                            if (splitSentence[indexOfThirdWord].Equals("") == false)
                            {
                                numberOfWords++;
                            }
                            if (numberOfWords == 3)
                            {
                                break;
                            }
                            else
                            {
                                indexOfThirdWord++;
                            }
                        }
                        Console.WriteLine($"The third word: {splitSentence[indexOfThirdWord]}");
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