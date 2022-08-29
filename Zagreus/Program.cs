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
            Random nmbr = new Random();
            int scrtNmbr = nmbr.Next(1, 11);
            int nmbrGuessed = 0;

            do
            {
                Console.WriteLine("Enter a nmbr between 1 and 10 : ");
                nmbrGuessed = Convert.ToInt32(Console.ReadLine());
            } while (scrtNmbr != nmbrGuessed);






            Console.ReadLine();
        }
    }
}