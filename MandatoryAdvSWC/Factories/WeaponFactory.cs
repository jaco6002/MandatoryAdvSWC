using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC.Factories
{
    public class WeaponFactory
    {
        public static Weapon Create(string Name)
        {
            Random rand=new Random(42);
            int rarity = rand.Next(101);

            if (rarity >= 0 && rarity < 50)
            {
                return new Weapon(rand.Next(2), rand.Next(2, 5), Name);
            }

            if (rarity>=50 && rarity<80)
            {
                return new Weapon(rand.Next(5,8), rand.Next(7, 12), Name);
            }

            if (rarity >= 80 && rarity <= 100)
            {
                return new Weapon(rand.Next(11, 15), rand.Next(14, 21), Name);
            }
            throw new Exception("something went wrong");
        }
    }
}
