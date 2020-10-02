using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC
{
    public abstract class Equipable
    {
        private int durability;
        private bool isEquipped=false;
        private (int,int) position;

        //public (int,int) Position
        //{
        //    get {
        //        if (!isEquipped)
        //        {
        //            return position;
        //        }
        //        else
        //        {
        //            return (-1, -1);
        //        }
        //    }
        //}

    }
}
