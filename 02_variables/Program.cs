using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Paul";
            Console.WriteLine(firstName);
            string lastName = "Johnson";
            int birthYear = 1990; 
            Console.WriteLine(lastName);

            sbyte signed8BitInt = -50; // -128 to 127
            byte unsigned8BitInt = 20; // 0 to 255
            short signed16BitInt = -23829; // -32,768 to 32,767
            ushort unsigned16BitInt = 58298; // 0 to 65,535
            int signed32BitInt = -2145392839; // -2,147,483,648 to 2,147,483,647
            uint unsigned32BitInt = 4283928432; // 0 to 4,294,967,295
            long signed64BitInt = -9223372036854775808; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong unsigned64BitInt = 18446744073709551615; // 0 to 18,446,744,073,709,551,615

            // docs.microsoft.com declared these using var 
            var decimalLiteral = 42;
            var hexLiteral = 0x2A;
            var binaryLiteral = 0b_0010_1010;

            Console.WriteLine(decimalLiteral);
            Console.WriteLine(hexLiteral);
            Console.WriteLine(binaryLiteral);

            Console.ReadLine();
        }
    }
}
