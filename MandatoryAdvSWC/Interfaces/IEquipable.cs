using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC.Interfaces
{
    public interface IEquipable
    {
        public int Durability { get; set; }
        public bool IsEquipped { get; set; }
        public IPosition Position { get; set; }

        public string Name { get; set; }

    }
}
