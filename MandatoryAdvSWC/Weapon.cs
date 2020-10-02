using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC
{
    public abstract class Weapon : Equipable
    {
        private Random rand;
        private int minDamage;
        private int maxDamage;

        public int Damage()
        {
            return rand.Next(minDamage, maxDamage + 1);
        }
    }
}
