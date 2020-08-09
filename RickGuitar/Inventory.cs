using System.Collections.Generic;

namespace RickGuitar
{
	public class Inventory
	{
		private List<Guitar> guitars;

		public Inventory() {
			guitars = new List<Guitar>();
		}

		public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
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

		public Guitar Search(Guitar searchGuitar)
		{
			string builder = searchGuitar.GetBuilder();
			string model = searchGuitar.GetModel();
			string type = searchGuitar.GetType();
			string backWood = searchGuitar.GetBackWood();
			string topWood = searchGuitar.GetTopWood();

			foreach (Guitar guitar in guitars) {
				if (builder != null && !builder.Equals("") && !builder.Equals(guitar.GetBuilder())) {
					continue;
				}

				if (model != null && !model.Equals("") && !model.Equals(guitar.GetModel()))
				{
					continue;
				}

				if (type != null && !type.Equals("") && !type.Equals(guitar.GetType()))
				{
					continue;
				}

				if (backWood != null && !backWood.Equals("") && !backWood.Equals(guitar.GetBackWood()))
				{
					continue;
				}

				if (topWood != null && !topWood.Equals("") && !topWood.Equals(guitar.GetTopWood()))
				{
					continue;
				}

				return guitar;
			}
			return null;
		}
	}
}
