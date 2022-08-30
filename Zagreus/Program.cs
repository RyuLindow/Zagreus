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
            int solution;

            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}", solution);




            Console.ReadLine();
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x *2;
        }

    }
}