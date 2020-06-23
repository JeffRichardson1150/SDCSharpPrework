using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            There are different data types for numbers.Which one you will use depends on the precision needed, thus making your program more efficient.

            Number Types Within C#
            ================================

            Type    Description
            int i = 0;          A  32 - bit whole number ranging from -2,147,483,648 to 2,147,483,647.In the expression, we assign 0 to the variable i.
            short sh = 32767;   A  16 - bit  whole number ranging from -32,768 to 32,767.In the expression we assign 32767 to the variable sh.
            byte by = 255;      An 8 - bit whole number ranging from 0 to 255.In the expression we assign 255 to the variable by.
            long l = 7;         A 64 - bit whole number ranging from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,808.Instead of long, we can use Int64.
            decimal p = 99.999999999999; A  128 - bit precision decimal with a range of 28 - 29 decimal places. A decimal data type is used to represent money or other values needing precision.
            double d = 7.80000000000000; A 64 - bit number with 15 - 16 decimal place accuracy..
            float f = 10.8f;    Half the size of a double at 32 bits.Must use f explicit conversion.
           

            decimal dd = 7.80m;	    Without the suffix m, the number is considered a double and generates a compiler error.
            int? ni = null;	        A? following the data type allows a value of null. Null means it can either have a value or be empty.
                       Example:
            You will want to use double or decimal when dealing with money or numbers needing accuracy.

                       The first Console.WriteLine() displays the decimal accuracy of a double.
            The second Console.WriteLine() rounds the number to two decimal places.
            */


            // "decimal Bill = 54.23" resulted in an error CS0664
            //  Severity	Code	Description	                                                    Project	      File	Line	                                                                                                                    Suppression State
            //   Error      CS0664  Literal of type double cannot be implicitly converted to type   08_numbers    C:\ElevenFiftySD\DotNetProjects\CSharpPrework\08_numbers\Program.cs   40  Active
            //                      'decimal'; use an 'M' suffix to create a literal of this type

            // decimal Bill = 54.23;
            decimal Bill = 54.23m;
            decimal Tip = 12;


            // "decimal Percentage = Tip / Bill;"     resulted in error
            //     Severity    Code Description Project File    Line Suppression State
            //     CS0019 Operator '/' cannot be applied to operands of type 'decimal' and 'double'   08_numbers C:\ElevenFiftySD\DotNetProjects\CSharpPrework\08_numbers\Program.cs 48  Active

            decimal Percentage = Tip / Bill;

            Console.WriteLine(Percentage);
            Console.WriteLine(Math.Round(Percentage, 2));
            Console.ReadLine();
        }
    }
}
