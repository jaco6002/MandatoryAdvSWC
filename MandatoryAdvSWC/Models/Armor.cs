using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAdvSWC.Interfaces;

namespace MandatoryAdvSWC
{
    public class Armor : Equipable
    {
		private int defence;

		public int Defence
		{
			get { return defence; }
			set { defence = value; }
		}

        public Armor(int defence, string Name)
        {
            this.defence = defence;
            this.Name = Name;
        }
        
    }
}
