using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAdvSWC.Interfaces;

namespace MandatoryAdvSWC
{
    public class Obstacle : IObstacle
    {
        public string Name { get; set; }
        public Position Position { get; set; }
    }
}
