using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC
{
    public class Weapon : Equipable
    {
        private static Random rand = new Random(42);
        private int minDamage;
        private int maxDamage;

        //public int MinDamage
        //{
        //    get { return minDamage; }
        //}

        //public int MaxDamage
        //{
        //    get { return maxDamage; }
        //}

        public int AvgDamage
        {
            get
            {
                return minDamage * maxDamage / 2;
            }
        }

        public Weapon(int minDamage, int maxDamage, string Name)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.Name = Name;
        }
        public Weapon(int minDamage, int maxDamage, string Name,Position position)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.Name = Name;
            this.Position = position;
        }

        public virtual int Damage()
        {
            return rand.Next(minDamage, maxDamage + 1);
        }
    }
}
