using System;
using System.Collections.Generic;

namespace RickGuitar
{
	public class FindGuitarTester
	{
		public static void Main(string[] args) {
			Inventory inventory = new Inventory();
			InitializeInventory(inventory);

			GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);

			List<Guitar> guitars = inventory.Search(whatErinLikes);

			if (guitars.Count > 0) {
				Console.WriteLine("Erin, you might like this:\n");
				int count = 1;
				foreach (Guitar guitar in guitars) {
					Console.WriteLine(count + ".");
					Console.WriteLine(guitar.getSpec().GetBuilder() + " " + guitar.getSpec().GetModel() + " " +
						guitar.GetType() + " guitar:\n " +
						guitar.getSpec().GetBackWood() + " back and sides,\n " +
						guitar.getSpec().GetTopWood() + " top.\n" +
						guitar.getSpec().getNumStrings() + " strings.\nYou can have it for only $" +
						guitar.GetPrice() + "!");
					count++;
				}
			}
			else {
				Console.WriteLine("Sorry, Erin, we have nothing for you.");
			}
		}

		public static void InitializeInventory(Inventory inventory)
		{
			inventory.AddGuitar(new Guitar("V95693", 1499.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12)));
			inventory.AddGuitar(new Guitar("V9512", 1549.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12)));
		}
	}
}
