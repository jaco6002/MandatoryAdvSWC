using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC
{
    public abstract class Creature
    {
        private Random rand;
        private int hitPoints;
        private int baseDamage;
        private List<Armor> armor;
        private Weapon weapon;
        private (int, int) position;
        private int defence;

        public int Defence
        {
            get
            {
                int sum = 0;
                foreach (var a in armor)
                {
                    sum = sum + a.Defence;
                }

                return sum;
            }
        }



        public virtual int Attack()
        {
            return baseDamage + weapon.Damage();
        }

        public virtual int Defend(int attack)
        {
            attack = attack - defence;
            if (attack>0)
            {
                attack = 0;
            }
            hitPoints = hitPoints - attack;
            return attack;
        }
    }
}
