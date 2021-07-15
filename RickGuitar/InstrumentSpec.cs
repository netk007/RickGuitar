using System;
using System.Collections.Generic;

namespace RickGuitar
{
	public class InstrumentSpec
	{
		private IDictionary<string, object> properties;

		public InstrumentSpec(IDictionary<string, object> properties)
		{
			if (properties == null)
			{
				this.properties = null;
			}
			else
			{
				this.properties = new Dictionary<string, object>(properties);
			}
		}

		public object GetProperty(string property)
		{
			return this.properties[property];
		}

		public IDictionary<string, object> GetProperties()
		{
			return this.properties;
		}

		public Boolean Equals(InstrumentSpec spec)
		{
			IDictionary<string, object> specProperties = spec.GetProperties();
			foreach (KeyValuePair<string, object> i in specProperties)
			{
				if (!this.properties[i.Key].Equals(i.Value))
				{
					return false;
				}
			}

			return true;
		}
	}
}
