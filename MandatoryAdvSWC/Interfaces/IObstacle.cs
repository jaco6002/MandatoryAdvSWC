using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC.Interfaces
{
    public interface IObstacle
    {
        public string Name { get; set; }
        public Position Position { get; set; }
    }
}
