using System.Collections.Generic;
using System.Security;

namespace RickGuitar
{
	public class Inventory
	{
		private List<Guitar> guitars;

		public Inventory() {
			guitars = new List<Guitar>();
		}

		public void AddGuitar(Guitar guitar)
		{
			guitars.Add(guitar);
		}

		public Guitar GetGuitar(string serialNumber)
		{
			foreach (Guitar guitar in guitars) {
				if (guitar.GetSerialNumber().Equals(serialNumber))
				{
					return guitar;
				}
			}
			return null;
		}

		public List<Guitar> Search(GuitarSpec searchSpec)
		{
			List<Guitar> matchedGuitars = new List<Guitar>();

			foreach (Guitar guitar in guitars)
			{
				if(guitar.GetSpec().Equals(searchSpec))
					matchedGuitars.Add(guitar);
			}
			return matchedGuitars;
		}
	}
}
