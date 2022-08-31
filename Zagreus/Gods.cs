using System;

namespace Zagreus
{
    internal class God
    {
        public string name;
        public string title;
        public string affiliation;

        public God()
        {
            name = "Nameless god";
            title = "of xxx";
            affiliation = "has no friends :(";
            numOfGods++;
        }

        public God(string name = "Nameless god",
            string title = "titleless",
            string affiliation = "has no friends :(")
        {
            this.name = name;
            this.title = title;
            this.affiliation = affiliation;
            numOfGods++;
        }

        public void GetTitle()
        {
            Console.WriteLine("{0} is called the {1}",
                name, title);
        }

        static int numOfGods = 0;

        public static int GetNumOfGods()
        {
            return numOfGods;
        }

    }
}
