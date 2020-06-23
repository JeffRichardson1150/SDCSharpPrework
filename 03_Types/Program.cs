using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Basic Types Within C#
            Here is a table of data types for C#:

            Type    Name    Example Description
            Integer int 20, -1500   A whole number with a size of 32 bits and range from - 2,147,483,648 to 2,147,483,647
            Integer short   20, -1500   A whole number with size 16 bits and range from - 32,768 to 32,767.
            Float   float   1.5f    32 bit, non - whole number, up to 7 digits
            Double  double  1.500000d   64 bit, up to 15 - 16 digits
            Decimal decimal 8.333333333333333333m   128 bit, up to 28 - 29 digits, more precise than double or float, but uses more memory.Used for financial situations
            Boolean bool    true, false A true or false value
            String  string  "Hello World"   A collection of characters with a size of up to 2 gigs
            */

            /*
            Types Reference For C#
            We have another table with .

            Declaration & Initialization	Description
            int i = 0;	        In the declaration, we initialize i to 0.
            short sh = 32767;	In the declaration, we initialize sh to 32767.
            byte by = 255;	    A whole number with size of 8 bits and range from 0 to 255. In the declaration, we initialize by to 255.
            string s = "hey!";	A collection of characters with a size of up to 2 gigs or 2^32 bytes, or Int32.MaxValue. In the declaration, we initialize s to "hey!"
            char c = 'i';	    A single character with a size of 16 bits. A string is a linked list of chars. In the declaration, we initialize c to the letter i.
            var s2 = @"a \tree";	We use the @ symbol to call a reference tree to specify a directory like \DotNetPreWork\HelloWorld.
            bool b = false;	    A boolean is a true or false value. In the declaration, we initialize b to false.
            long l = 7;	        Long is a large integer data type. Exactly 2 times more. The size is 64 bit and the range is -9,223,372,036,854,775,808 to 9,223,372,036,854,775,808. We can use Int64 in place of long.
            decimal p = 99.99999999999999999999999999;	A 128-bit precision decimal with a range of 28-29 decimal places. Consumes more memory than other numeric types. A decimal data type is used when needing precise values.
            double d = 7.80000000000000;	Has a 15-16 digit precision with a 64-bit size.
            float f = 10.8f;	Floating point number, need f explicit conversion after the number. Float is stored as 32 bits, half the size of a double.
            decimal dd = 7.80m;	Without the suffix m, the number is a double and generates a compiler error.
            int? ni = null;	A ? after the data type allows a value of null. Null means it can either have a value or be empty. Null is used when you are't sure if there will be a value or not, such as with web services or database results. Use .HasValue to see if the current Nullable object has a valid value of its underlying type.
            */

            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            decimal accountBalance = 80000.30m;

            Console.WriteLine(accountBalance);

            int twentyThree = 23;
            float threeBucks = 3.33f;
            double fifteenPoint = 15.25456d;
            short negThirtyFive = -3500;
            string hiExclamation = "Hi!";

            Console.WriteLine(twentyThree);
            Console.WriteLine(threeBucks);
            Console.WriteLine(fifteenPoint);
            Console.WriteLine(negThirtyFive);
            Console.WriteLine(hiExclamation);

            Console.ReadLine();
        }
    }
}
