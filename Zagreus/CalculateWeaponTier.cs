using System;

namespace Zagreus
{
    public static class CalculateWeaponScore
    {
        public static double GetScores(string score = "",
            double damage = 6,
            double speed = 9)
        {
            if (String.Equals("Godkiller",
            score,
            StringComparison.OrdinalIgnoreCase))
            {
                return damage * speed;
            } else if (String.Equals("Legendary",
            score,
            StringComparison.OrdinalIgnoreCase))
            {
                return damage * (speed / 2);
            } else if (String.Equals("Mortal",
            score,
            StringComparison.OrdinalIgnoreCase))
            {
                return (damage / 2) * (speed / 2);
            } else
            {
                return -1;
            }
        }
    }
}
