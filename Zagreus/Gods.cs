using System;
using System.Linq;

namespace Zagreus
{
    class God
    {
        private string name;
        private string domain;

        public const string AFFILIATION = "Mount Olympus";

        public readonly int godCount;

        public void MyDomain()
        {
            Console.WriteLine("{0}'s domain is {1}",
                name, domain);
        }

        public God()
        :this("Nameless", "No domain") { }

        public God(string name)
        :this(name, "Nameless") { }

        public God(string name, string domain) 
        {
            SetName(name);
            Domain = domain;

            NumOfDomains = 1;

            Random rnd = new Random();
            godCount = rnd.Next(1, 2147483640);
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            } else
            {
                this.name = "Nameless";
                Console.WriteLine("A name can't have numbers in it...");
            }
        }

        public string GetName()
        {
            return name;
        }

        public string Domain
        {
            get { return domain; }
            set
            {
                if(value.Length > 27)
                {
                    domain = "No domain";
                    Console.WriteLine("This domain doesn't exist");
                }

                domain = value;
            }
        }

        public string Parent
        {
            get;
            set;
        } = "No ruler";

        public static int numOfDomains = 0;

        public static int NumOfDomains
        {
            get { return numOfDomains; }
            set { numOfDomains += value; }
        }
    }
}
