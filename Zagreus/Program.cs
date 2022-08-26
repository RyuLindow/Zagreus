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
            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Original : {0}, Cast : {1}", num1.GetType(), num2.GetType());



            Console.ReadLine();
        }

    }
}
