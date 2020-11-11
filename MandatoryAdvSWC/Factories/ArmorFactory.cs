using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC.Factories
{
    public class ArmorFactory
    {
        private static Random rand = new Random(42);
        public static Armor CreateWithRandPosition(string Name, World w)
        {
            int rarity = rand.Next(101);
            Position p = new Position() { X = rand.Next(w.MaxX), Y = rand.Next(w.MaxY) };
            return new Armor(rand.Next(10),Name){Position = p};
        }
    }
}
