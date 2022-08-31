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
            InternalArms Varatha;
            Varatha.damage = 9;
            Varatha.speed = 5;
            Console.WriteLine("Rank score of Varatha : {0}", Varatha.RankScore());


            InternalArms Stygius = new InternalArms(4, 10);

            Console.WriteLine("Rank score of Stygius : {0}", Stygius.RankScore());

            Varatha = Stygius;
            Stygius.damage = 5;

            Console.WriteLine("Rank score of Stygius's dmg : {0}", Stygius.damage);


            Console.ReadLine();
        }

        struct InternalArms
        {
            public double damage;
            public double speed;

            public InternalArms(double d,
                double s)
            {
                damage = d;
                speed = s;
            }

            public double RankScore()
            {
                return damage * speed;
            }


        }


    }
}