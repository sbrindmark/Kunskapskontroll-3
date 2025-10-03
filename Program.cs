using System;

namespace Kodanalys
{
    class program
    {
        static string[] customers = new string[10];
        static int customerCount = 0;

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        string userName = Console.ReadLine();
                        if (customerCount < 10)
                        {
                            customers[customerCount] = userName;
                            customerCount++;
                        }
                        else
                        {
                            Console.WriteLine("Listan är full!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Användare:");
                        for (int i = 0; i < customerCount; i++)
                        {
                            Console.WriteLine(customers[i]);
                        }
                        break;

                    case "3":
                        Console.Write("Ange namn att ta bort: ");
                        string removeUserName = Console.ReadLine();
                        int removeIndex = -1;
                        for (int i = 0; i < customerCount; i++)
                        {
                            if (customers[i] == removeUserName)
                            {
                                removeIndex = i;
                                break;
                            }
                        }
                        if (removeIndex != -1)
                        {
                            for (int i = removeIndex; i < customerCount - 1; i++)
                            {
                                customers[i] = customers[i + 1];
                            }
                            customerCount--;
                        }
                        else
                        {
                            Console.WriteLine("Användaren hittades inte.");
                        }
                        break;

                    case "4":
                        {
                            Console.Write("Ange namn att söka: ");
                            string searchUserName = Console.ReadLine();
                            bool userFound = false;
                            for (int i = 0; i < customerCount; i++)
                            {
                                if (customers[i] == searchUserName)
                                {
                                    userFound = true;
                                    break;
                                }
                            }
                            if (userFound)
                            {
                                Console.WriteLine("Användaren finns i listan.");
                            }
                            else
                            {
                                Console.WriteLine("Användaren hittades inte.");
                            }
                        }
                        break;
                    case "5":

                        isRunning = false;
                        Console.WriteLine("Ogiltigt val.");

                        break;

                        Console.WriteLine();

                }

            }
        }

    }
}
