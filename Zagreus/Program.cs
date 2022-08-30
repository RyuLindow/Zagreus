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
            PrintInfo(location: "Shade", name: "Eurydice");


            Console.ReadLine();
        }
        
        static void PrintInfo(string name, string location)
        {
            Console.WriteLine("{0} lives in the {1}",
                name, location);
        }
    }
}