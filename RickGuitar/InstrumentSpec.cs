using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace RickGuitar
{
	public abstract class InstrumentSpec
	{
		private string model;
		private Builder builder;
		private Type type;
		private Wood backWood;
		private Wood topWood;

		public InstrumentSpec(string model, Builder builder, Type type, Wood backWood, Wood topWood)
		{
			this.builder = builder;
			this.model = model;
			this.type = type;
			this.backWood = backWood;
			this.topWood = topWood;
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

		public Boolean Equals(InstrumentSpec spec)
		{
			string model = spec.model;

			if (model != null && model != "" && this.model != spec.model)
				return false;
			if (this.builder != spec.builder)
				return false;
			if (this.type != spec.type)
				return false;
			if (this.backWood != spec.backWood)
				return false;
			if (this.topWood != spec.topWood)
				return false;

			return true;
		}
	}
}
