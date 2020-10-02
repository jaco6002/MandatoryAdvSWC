using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAdvSWC
{
    public abstract class Armor :Equipable
    {
		private int defence;

		public int Defence
		{
			get { return defence; }
			set { defence = value; }
		}

	}
}
