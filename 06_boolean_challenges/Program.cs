using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            float value = 101/2f;
            Console.WriteLine(value);
            if (value == 50)
            {
                Console.WriteLine(true);
            }
            // Bronze challenge
            else
            {
                Console.WriteLine(false);
            }

            // Console.ReadLine();

            int correctGuess = 3;
            Console.WriteLine("Guess a number between 1 and 10");
            // int guessNum = Convert.ToInt16(Console.ReadLine());
            string guess = Console.ReadLine();
            int guessNum = Int32.Parse(guess);
            // Console.WriteLine(guess);

            if (guessNum == correctGuess)
            {
                Console.WriteLine("Nice job! You guessed correctly.");
            }
            else if (guessNum < correctGuess)
            {
                Console.WriteLine("Choose a higher number.");
            }
            else
            {
                Console.WriteLine("Choose a lower number.");

            }

            Console.ReadLine();

        }
    }
}
