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
            int[] rndNmbrs = { 1, 0, 0, 2, 9, 5 };

            Array.Sort(rndNmbrs);

            Array.Reverse(rndNmbrs);

            rndNmbrs.SetValue(7, 0);

            Console.WriteLine("1 at Index : {0}",
                Array.IndexOf(rndNmbrs, 1));


            PrintArray(rndNmbrs, "ForEach");


        }

        static void PrintArray(int[] intArray, string msg)
        {
            foreach (int n in intArray)
            {
                Console.WriteLine( "{0} : {1} ", msg, n);
            }

            Console.ReadLine();
        }

    }
}
