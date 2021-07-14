using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitar
{
	public class GuitarSpec: InstrumentSpec
	{
		
		private int numStrings;

		public GuitarSpec(string model, Builder builder, Type type, Wood backWood, Wood topWood, int numStrings) : base(model, builder, type, backWood, topWood)
		{
			this.numStrings = numStrings;
		}

		public int GetNumStrings()
		{
			return numStrings;
		}

		public bool Equals(GuitarSpec spec)
		{
			if (!base.Equals((InstrumentSpec)spec))
				return false;
			if (this.numStrings != spec.numStrings)
				return false;

			return true;
		}
	}
}
