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
            God Zagreus = new God()
            {
                name = "Zagreus",
                title = "Prince of the Underworld",
                affiliation = "House of Hades"
            };

            Zagreus.GetTitle();

            Console.WriteLine("{0} is called the {1} and he's a part of the {2}\nThere is {3} god",
                Zagreus.name, Zagreus.title, Zagreus.affiliation, God.GetNumOfGods());



            Console.ReadLine();
        }

    }
}