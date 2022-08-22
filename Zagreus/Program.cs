using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zagreus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zagreus");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Char {0} : {1}", i, args[i]);
            }
             
            string[] myChars = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myChars));

            Console.ReadLine(); 
        }
    }
}
