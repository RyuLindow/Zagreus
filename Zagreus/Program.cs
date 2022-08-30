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
            furies fury1 = furies.Megaera;
            furies fury2 = furies.Alecto;
            furies fury3 = furies.Tisiphone;

            SlainFury(fury2);


            Console.ReadLine();
        }
        
        enum furies :  byte
        {
            Megaera = 1,
            Alecto,
            Tisiphone
        }

        static void SlainFury(furies cc)
        {
            Console.WriteLine("The fury{1} named {0} was slain by Zagreus",
                cc, (int)cc);
        }
    }
}