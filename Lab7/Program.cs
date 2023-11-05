using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            Console.WriteLine("Enter a number of stars:  ");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out int numStars);
            if (numStars <= 0)
            {
                Console.WriteLine("Sorry, invalid input.");
            }
            else
            {
                ShowSquareOfStars(numStars);
            }


        }
        static void ShowSquareOfStars(int numStars)
        {
            string star = "*";

            for (int x = 0; x < numStars; ++x)
            {
                for (int y = 0; y < numStars;  ++y)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
    
}
