using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC.Interfaces
{
    public interface ICreature
    {
        public int Hitpoints { get; set; }
        public string Name { get; set; }
        public Armor EquippedArmor { get; }
        public Weapon EquippedWeapon { get;}
        public Position Position { get; set; }
        int Attack();
        int Defend(int attack);
        void Loot(IEquipable equipable);

    }
}
