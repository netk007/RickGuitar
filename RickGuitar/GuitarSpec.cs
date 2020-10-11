using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitar
{
	public class GuitarSpec
	{
		private Builder builder;
		private string model;
		private Type type;
		private Wood backWood;
		private Wood topWood;
		private int numStrings;

		public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
		{
			this.builder = builder;
			this.model = model;
			this.type = type;
			this.backWood = backWood;
			this.topWood = topWood;
			this.numStrings = numStrings;
		}

		public Builder GetBuilder()
		{
			return builder;
		}

		public string GetModel()
		{
			return model;
		}

		public new Type GetType()
		{
			return type;
		}

		public Wood GetBackWood()
		{
			return backWood;
		}

		public Wood GetTopWood()
		{
			return topWood;
		}

		public int getNumStrings()
		{
			return numStrings;
		}

		public bool matches(GuitarSpec spec)
		{
			string model = spec.model;

			if (this.builder != spec.builder)
				return false;
			if (model != null && model != "" && this.model != spec.model)
				return false;
			if (this.type != spec.type)
				return false;
			if (this.backWood != spec.backWood)
				return false;
			if (this.topWood != spec.topWood)
				return false;
			if (this.numStrings != spec.numStrings)
				return false;

			return true;
		}
	}
}
