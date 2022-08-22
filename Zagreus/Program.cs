using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Zagreus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomString = "This is quite random";
            Console.WriteLine("The string length is {0}",
                randomString.Length);

            randomString = randomString.ToUpper();
            Console.WriteLine("The string contains is {0}",
                randomString.Contains("IS"));

            Console.WriteLine("Index of is {0}",
                randomString.IndexOf("IS"));
            
            Console.WriteLine("Remove string {0}",
                randomString.Remove(5, 3));
            
            Console.WriteLine("Insert string {0}",
                randomString.Insert(7, " actually"));

            Console.WriteLine("Replace string {0}",
                randomString.Replace("QUITE RANDOM", "a quite random string"));

            Console.WriteLine("Compare A to B {0}",
                String.Compare("Zagreus", "Hades", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Compare A to a {0}",
                String.Equals("Zagreus", "Hades", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Pad left {0}",
                randomString.PadLeft(20, '.'));

            Console.WriteLine("Pad right {0}",
                randomString.PadRight(20, '.'));

            Console.WriteLine("Trim {0}" ,
                randomString.Trim());

            Console.WriteLine("Upper {0}",
                randomString.ToUpper());

            Console.WriteLine("Lower {0}",
                randomString.ToLower());

            string newString = String.Format("{0} slayed {1} {2} {3} in the {4}", "Zagreus", "his", "father", "Hades", "Styx\a");

            Console.WriteLine(newString);

            Console.Write(@"It was a great battle! -.-");

            Console.ReadLine();
        }

    }
}
