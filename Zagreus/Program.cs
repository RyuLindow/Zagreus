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
            DateTime dateOfTheDate = new DateTime(1995, 02, 10);
            Console.WriteLine("Day of the week in 1995: {0}", dateOfTheDate.DayOfWeek);

            dateOfTheDate = dateOfTheDate.AddDays(7);
            dateOfTheDate = dateOfTheDate.AddMonths(0);
            dateOfTheDate = dateOfTheDate.AddYears(15);

            Console.WriteLine("Day of the week in 2010 : {0}", dateOfTheDate.Date);

            TimeSpan birthday = new TimeSpan(9, 45, 0);
            birthday = birthday.Add(new TimeSpan(0, 0, 18));
            birthday = birthday.Subtract(new TimeSpan(0, 0, 1));

            Console.WriteLine("My birthday was around : {0}", birthday);
            Console.WriteLine("My birthday was around : {0}", birthday.ToString());

            Console.ReadLine(); 
        }

    }
}
