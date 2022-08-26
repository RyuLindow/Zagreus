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

            int[] srcArray = { 10, 02, 95 };
            int[] destArray = new int[2];
            int startIndx = 0;
            int length = 2;

            Array.Copy(srcArray, startIndx, destArray, startIndx, length);

            PrintArray(destArray, "Copy");

            Array nthrArray = Array.CreateInstance(typeof
                (int), 10);

            srcArray.CopyTo(nthrArray, 5);

            foreach (int i in nthrArray)
            {
                Console.WriteLine("CopyTo : {0}", i);
            }

            int[] numArray = { 10, 17, 06 };

            Console.WriteLine("> 10 : {0}", Array.Find(numArray, grtrThn10));




            Console.ReadLine();
        }

        static void PrintArray(int[] intArray, string msg)
        {
            foreach (int n in intArray)
            {
                Console.WriteLine( "{0} : {1} ", msg, n);
            }
        }

        private static bool grtrThn10(int val)
        {
            return val > 10;
        }

    }
}
