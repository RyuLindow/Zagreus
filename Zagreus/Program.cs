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
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}",
                GetSum(x, y));

            Console.WriteLine("New values for x {0}", x);


            Console.ReadLine();
        }

        static double GetSum(double x = 1, double y = 1)
        {
            double tempVrbl = x;
            x = y;
            y = tempVrbl;

            return x + y;
        }


    }
}