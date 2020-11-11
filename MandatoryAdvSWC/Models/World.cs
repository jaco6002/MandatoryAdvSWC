using System;
using MandatoryAdvSWC.Interfaces;

namespace MandatoryAdvSWC
{
    public abstract class World:IWorld
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
    }
}
