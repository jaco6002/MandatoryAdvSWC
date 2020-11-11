using System;
using System.Collections.Generic;
using MandatoryAdvSWC.Interfaces;

namespace MandatoryAdvSWC
{
    public class World:IWorld
    {
        private List<IEquipable> equipables = new List<IEquipable>();
        private List<IObstacle> obstacles = new List<IObstacle>();
        private List<ICreature> creatures = new List<ICreature>();
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public List<IEquipable> Equipables
        {
            get => equipables;
            set => equipables = value;
        }

        public List<IObstacle> Obstacles
        {
            get => obstacles;
            set => obstacles = value;
        }

        public List<ICreature> Creatures
        {
            get => creatures;
            set => creatures = value;
        }


        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }
    }
}
