using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MandatoryAdvSWC.Interfaces;

namespace MandatoryAdvSWC
{
    public class Creature : ICreature
    {
        private int hitpoints;

        private string name;
        private static Random rand=new Random(42);
        private int strength;
        private List<Armor> armorInventory= new List<Armor>();
        private Armor equippedArmor;
        private Weapon equippedWeapon;
        private List<Weapon> weaponInventory = new List<Weapon>();

        public int Hitpoints
        {
            get => hitpoints;
            set => hitpoints = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Armor EquippedArmor
        {
            get
            {
                Armor toReturn = armorInventory[0];
                foreach (var armor in armorInventory)
                {
                    if (toReturn.Defence < armor.Defence)
                    {
                        toReturn = armor;
                    }
                }
                return toReturn;
            }
        }

        public Weapon EquippedWeapon
        {
            get
            {
                Weapon toReturn = weaponInventory[0];
                foreach (var weapon in weaponInventory)
                {
                    if (toReturn.AvgDamage<weapon.AvgDamage)
                    {
                        toReturn = weapon;
                    }
                }
                return toReturn;
            }
        }

        public Position Position { get; set; }

        public Creature(int hitpoints, string name, int strength)
        {
            this.hitpoints = hitpoints;
            this.name = name;
            this.strength = strength;
            armorInventory.Add(new Armor(1,"BaseArmor"));
            weaponInventory.Add(new Weapon(1,1,"BaseWeapon"));
        }

        public virtual int Attack()
        {
            return strength + equippedWeapon.Damage();
        }

        public virtual int Defend(int attack)
        {
            attack = attack - equippedArmor.Defence;
            if (attack > 0)
            {
                attack = 0;
            }
            hitpoints = hitpoints - attack;
            if (hitpoints<0)
            {
                hitpoints = 0;
            }
            return attack;
        }


        public virtual void Loot(IEquipable equipable)
        {
            if (equipable is Armor)
            {
                armorInventory.Add((Armor)equipable);
            }
            else if (equipable is Weapon)
            {
                weaponInventory.Add((Weapon)equipable);
            }
            else
            {
                throw new Exception("Type not implemented yet");
            }
        }
    }
}
