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

            int age = 1;

            bool millenial = age >= 18 ?/*then*/ true :/*else*/ false;

            switch (age)
            {
                case 12:
                    Console.WriteLine("Gen of watching mobile ads");
                    break;

                case 25:
                    Console.WriteLine("not sure if zoomer or not");
                    break;

                case 27:
                    Console.WriteLine("Millenial");
                    break;

                default:
                    Console.WriteLine("Tough luck");

                    goto Ageless;
            }
        Ageless:
            Console.WriteLine("Dead");

            string name1 = "Darek";
            string name2 = "Laura";
            string name3 = "Mati";

            if(name1.Equals(name3, 
                StringComparison.Ordinal))
            {
                Console.WriteLine("Same name");
            }
            else
            {
                Console.WriteLine("Not same");

            }

            Console.ReadLine();
        }
    }
}