using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int forcount=500; forcount<=525; forcount++)
            {
                Console.WriteLine(forcount);
                    }
            Console.ReadLine();

            for (int byFive = 0; byFive <= 100; byFive += 5)
            {
                Console.WriteLine(byFive);
            }
            Console.ReadLine();

            for (int fizzBuzz = 1; fizzBuzz <= 100; fizzBuzz++)
            {
                if (fizzBuzz % 5 == 0  && fizzBuzz % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizzBuzz % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fizzBuzz % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(fizzBuzz);
                }
            }
            Console.ReadLine();
        }
    }
}
