using System;

namespace HW_2C
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            
            while (running)
            {
                // Display the menu
                Console.WriteLine("**************");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine();
                Console.WriteLine("1 - New Game");
                Console.WriteLine();
                Console.WriteLine("2 - Load Game");
                Console.WriteLine();
                Console.WriteLine("3 - Options");
                Console.WriteLine();
                Console.WriteLine("4 - Quit");
                Console.WriteLine();
                Console.WriteLine("**************");
                Console.WriteLine();
                Console.Write("Please enter your choice (1-4): ");
                
                // Get user input
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                // Handle user choice
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected: New Game");
                        break;
                    case "2":
                        Console.WriteLine("You selected: Load Game");
                        break;
                    case "3":
                        Console.WriteLine("You selected: Options");
                        break;
                    case "4":
                        Console.WriteLine("Thanks for using the menu! Goodbye!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        break;
                }
                
                if (running)
                {
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}