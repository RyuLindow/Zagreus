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
            StringBuilder sb1 = new StringBuilder("The voice acting is great!");

            StringBuilder sb2 = new StringBuilder("And so is the music :)", 256);

            Console.WriteLine("Capacity : {0}", sb1.Capacity);
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            Console.WriteLine("Length : {0}", sb1.Length);
            Console.WriteLine("Length : {0}", sb2.Length);

            sb2.AppendLine("\r");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            string bestChar = "Megaera";
            sb2.AppendFormat(enUS, "Best character : {0}",
                bestChar);
            Console.WriteLine(sb2.ToString());

            sb2.Replace("music", "art style");
            Console.WriteLine(sb2.ToString());

            sb2.Clear();

            sb2.Append("Transistor was also a great game");
            Console.WriteLine(sb1.Equals(sb2));

            sb2.Insert(32, " : Amazing studio : Supergiant Games");
            Console.WriteLine(sb2.ToString());

            sb2.Remove(0, 1);
            Console.WriteLine(sb2.ToString());

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
