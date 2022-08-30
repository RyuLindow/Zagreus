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
            Console.WriteLine("5.4 + 4.5 = {0}",
                GetSum(5.0, 4.5));

            Console.WriteLine("5 + 4 = {0}",
                GetSum(5, 4));

            Console.WriteLine("5 + 4 = {0}",
                GetSum("5", "4"));

            Console.ReadLine();
        }
        
        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum(string x = "1", string y = "1")
        {

            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

    }
}