using System;
using MandatoryAdvSWC;
using MandatoryAdvSWC.Factories;

namespace testingFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            World w = new World(100,100);
            for (int i = 0; i < 5; i++)
            {
                Weapon wp = WeaponFactory.CreateWithRandPosition("Weapon" + i, w);
                Armor ar = ArmorFactory.CreateWithRandPosition("Armor"+i,w);
                w.Equipables.Add(ar);
                w.Equipables.Add(wp);
                Console.WriteLine("created armor at ("+ar.Position.X+","+ar.Position.Y+")");
                Console.WriteLine("created weapon at (" + wp.Position.X + "," + wp.Position.Y + ")");

            }
            Creature player = new Creature(1000,"Player",1);
            Creature enemy = new Creature(1000,"Enemy",0);
            for (int i = 0; i < 5; i++)
            {
                player.Loot(w.Equipables[i]);
                enemy.Loot(w.Equipables[i+5]);
            }

        }
    }
}
