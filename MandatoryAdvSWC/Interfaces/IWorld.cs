using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC.Interfaces
{
    public interface IWorld
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public List<IEquipable> Equipables { get; set; }
        public List<IObstacle> Obstacles { get; set; }
        public List<ICreature> Creatures { get; set; }
    }
}
