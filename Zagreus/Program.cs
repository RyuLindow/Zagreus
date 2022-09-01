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
            God Nyx = new God();

            Nyx.SetName("Nyx");
            Nyx.Domain = "Night"; 

            Console.WriteLine("{0}'s domain is the {1}",
                Nyx.GetName(), Nyx.Domain);

            Nyx.Parent = "Chaos";

            Console.WriteLine("{0}'s parent is {1}",
                Nyx.GetName(), Nyx.Parent);

            Console.WriteLine("{0} has {1} children",
                Nyx.Parent, Nyx.godCount);

            God Charon = new God("Charon", "Styx");

            Console.WriteLine("There are {0} gods",
                God.NumOfDomains);


            Console.ReadLine();
        }

    }
}