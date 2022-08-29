using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace Zagreus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 12;

            if ((age >= 26) && (age <= 43))
            {
                Console.WriteLine("Millenial");
            }
            else if ((age > 43) && (age <= 59))
            {
                Console.WriteLine("Gen X");
            }
            else if ((age > 59) && (age <= 77))
            {
                Console.WriteLine("Boomer");
            }
            else
            {
                Console.WriteLine("Dead");
            }


            if ((age < 10) || (age < 13))
            {
                Console.WriteLine("Robal");
            }

            Console.WriteLine("!true = " + (!true));





            Console.ReadLine();
        }

    }
}
