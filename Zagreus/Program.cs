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
            int[] bDayNums = new int[3];

            bDayNums[0] = 10;
            bDayNums[1] = 02;
            bDayNums[2] = 95;
            
            Console.WriteLine("bDayNums 0 : {0}",
                bDayNums[2]);

            string[] siblings = { "Zagreus", "Thanatos", "Hypnos" };

            var furies = new[] { "Megaera", "Alecto", "Tisiphone" };

            object[] godBrothers = { "Hades", "Zeus", "Poseidon", "99", "171.6" };

            Console.WriteLine("godBrothers 0: {0}",
                godBrothers[4].GetType());

            Console.WriteLine("Array size: {0}",
                godBrothers.Length);

            for (int i = 0; i < godBrothers.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                    i, godBrothers[i]);
            }

            string[,] notableCharNames = new string[2, 2] { { "Theseus", "Asterius" }, { "Achilles", "Patroclus" } };

            Console.WriteLine("Notable character names : {0}",
                notableCharNames.GetValue(0,1));

            for (int i = 0; i < notableCharNames.GetLength(0); i++)
            {
                for (int h = 0; h < notableCharNames.GetLength(1); h++)
                {
                    Console.Write("Notable character name : {0} \n",
                        notableCharNames[i, h]);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }

    }
}
