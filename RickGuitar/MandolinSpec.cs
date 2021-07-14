using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitar
{
	public class MandolinSpec : InstrumentSpec
	{
		private Style style;

		public MandolinSpec(string model, Builder builder, Type type, Wood backWood, Wood topWood, Style style) : base(model, builder, type, backWood, topWood)
		{
			this.style = style;
		}

		public Style GetStyle()
		{
			return style;
		}

		public bool Equals(MandolinSpec spec)
		{
			if (!base.Equals((InstrumentSpec)spec))
				return false;
			if (this.style != spec.style)
				return false;

			return true;
		}
	}
}
