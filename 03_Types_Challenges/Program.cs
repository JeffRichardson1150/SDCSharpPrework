using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNoInit;
            int intInit = 5;
            string strNoInit;
            string strInit = "Initialize the string";
            bool boolNoInit;
            bool boolInit = true;
            float floatNoInit;
            float floatInit = 10.23f;
            double dblNoInit;
            double dblInit = 253.29383d;
            decimal decNoInit;
            decimal decInit = 10384739.2984933m;

            string strInit2 = "Another string";

            Console.WriteLine(dblInit);
            Console.WriteLine(floatInit);
            Console.WriteLine(decInit);

            // Silver Challenge :
            Console.WriteLine(strInit + " " + strInit2);

            // Gold Challenge :
            int yearIWasBorn = 1962;
            string yearBornString = yearIWasBorn.ToString();
            Console.WriteLine("I was born in " + yearBornString);

            Console.ReadLine();
        }
    }
}
