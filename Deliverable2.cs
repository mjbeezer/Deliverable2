using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chat Bot");

            bool conversation = true;

            //Chat Bot responses based on following user inputs: hello, bye, sup and hello there. Corresponding chat bot responses: hi good to see you, good bye!, I am good and General Kenobi respectively

            while (conversation)
            {
                Console.WriteLine("What do we wish to say to the chat bot?");
                string userInput1 = Console.ReadLine();

                if (userInput1.ToLower() == "hello")
                {
                    Console.WriteLine("Hi good to see you.");

                }
                else if (userInput1.ToLower() == "sup")
                {
                    Console.WriteLine("I am good.");

                }
                else if (userInput1.ToLower() == "hello there")
                {
                    Console.WriteLine("General Kenobi.");

                }
                else if (userInput1.ToLower() == "bye")
                {
                    Console.WriteLine("good bye.");
                    conversation = false;
                }
            }//I am not skilled enough to make an array/list/dictionary to store responses and execute code " Im sorry but you have already said that."
        }
    }
}
