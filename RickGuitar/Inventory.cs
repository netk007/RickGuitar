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

		public void AddGuitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
		{
			Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
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

		public List<Guitar> Search(Guitar searchGuitar)
		{
			string model = searchGuitar.GetModel().ToLower();
			List<Guitar> matchedGuitars = new List<Guitar>();

			foreach (Guitar guitar in guitars) {
				if (searchGuitar.GetBuilder() != guitar.GetBuilder()) {
					continue;
				}

				if (model != null && !model.Equals("") && !model.Equals(guitar.GetModel().ToLower()))
				{
					continue;
				}

				if (searchGuitar.GetType() != guitar.GetType())
				{
					continue;
				}

				if (searchGuitar.GetBackWood() != guitar.GetBackWood())
				{
					continue;
				}

				if (searchGuitar.GetTopWood() != guitar.GetTopWood())
				{
					continue;
				}

				matchedGuitars.Add(guitar);
			}
			return matchedGuitars;
		}
	}
}
