using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string yourName = "Schlamazle";

            // Concatenation
            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);

            // Composite Formatting
            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            // String Interpolation
            string firstName2 = "Robin";
            string lastName2 = "Holler";
            Console.WriteLine($"Her name is {firstName2} {lastName2}");

            Console.ReadLine();

        }
    }
}
