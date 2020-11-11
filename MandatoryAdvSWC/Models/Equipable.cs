using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAdvSWC.Interfaces;

namespace MandatoryAdvSWC
{
    public abstract class Equipable: IEquipable
    {
        private bool isEquipped=false;
        private IPosition? position;
        private string name;

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


        public bool IsEquipped
        {
            get => isEquipped;
            set => isEquipped = value;
        }

        public IPosition? Position
        {
            get
            {
                if (!isEquipped)
                {
                    return position;
                }
                else
                {
                    return null;
                }
            }
            set => position = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
