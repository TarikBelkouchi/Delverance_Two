using System;

namespace Deliverance_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            string userInput = "";

            Console.WriteLine("\t| Welcome to BotChat! |");


            while (running)
            {
                Console.Write("\nSay something to Bot : ");
                string input = Console.ReadLine().ToLower();

                if (input == userInput)
                {
                    Console.WriteLine("I’m sorry but you have already said that");
                }
                else
                {
                    if (input == "hello")
                        Console.WriteLine("Hi good to see you");
                    else if (input == "bye")
                    {
                        Console.WriteLine("Good bye!");
                        running = false;
                    }
                    else if (input == "sup")
                        Console.WriteLine("I'm Good");
                    else if (input == "hello there")
                        Console.WriteLine("General Kenobi");
                }
                userInput = input;

            }
        }
    }
}
