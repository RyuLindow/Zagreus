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
            Console.WriteLine("Currency : {0:c}", 161.7); 
            Console.WriteLine("Pad with 0s : {0:d4}", 162); 
            Console.WriteLine("3 decimals : {0:f3}", 162.70101); 
            Console.WriteLine("Commas : {0:n2}", 1162 ); 

            Console.ReadLine();
        }

    }
}
