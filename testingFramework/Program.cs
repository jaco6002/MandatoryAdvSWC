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
            Console.WriteLine("creating weapons and armor----------------------------");
            for (int i = 0; i < 5; i++)
            {
                Weapon wp = WeaponFactory.CreateWithRandPosition("Weapon" + i, w);
                Armor ar = ArmorFactory.CreateWithRandPosition("Armor"+i,w);
                w.Equipables.Add(ar);
                w.Equipables.Add(wp);
                Console.WriteLine("created armor at ("+ar.Position.X+","+ar.Position.Y+")");
                Console.WriteLine("created weapon at (" + wp.Position.X + "," + wp.Position.Y + ")");

            }

            Console.WriteLine("making player and an enemy, and distributing weapons and armor-------------------------");
            Creature player = new Creature(1000,"Player",1);
            Creature enemy = new Creature(1000,"Enemy",0);
            for (int i = 0; i < 5; i++)
            {
                player.Loot(w.Equipables[i]);
                enemy.Loot(w.Equipables[i+5]);
            }

            Console.WriteLine("enemy and player fight to the death");
            int c = 1;
            bool alive = true;
            while (alive)
            {
                if (c%2==0)
                {
                    int atk = player.Attack();
                    enemy.Defend(player.Attack());
                    Console.WriteLine("player attacks dealing: " + atk + " damage");
                    Console.WriteLine("enemy remaining hp: "+enemy.Hitpoints);
                    if (enemy.Hitpoints==0)
                    {
                        alive = false;
                    }
                }
                else
                {
                    int atk = enemy.Attack();
                    player.Defend(atk);
                    Console.WriteLine("enemy attacks dealing: " + atk + " damage");
                    Console.WriteLine("player remaining hp: " + player.Hitpoints);
                    if (player.Hitpoints == 0)
                    {
                        alive = false;
                    }
                }
                c++;
            }

            //Console.WriteLine("hitpints remaining");
            //Console.WriteLine("enemy hitpoints: "+enemy.Hitpoints);
            //Console.WriteLine("player hitpoints: " + player.Hitpoints);


        }
    }
}
