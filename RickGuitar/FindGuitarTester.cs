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
					Console.WriteLine(guitar.GetSpec().GetBuilder() + " " + guitar.GetSpec().GetModel() + " " +
						guitar.GetSpec().GetType() + " guitar:\n " +
						guitar.GetSpec().GetBackWood() + " back and sides,\n " +
						guitar.GetSpec().GetTopWood() + " top.\n" +
						guitar.GetSpec().GetNumStrings() + " strings.\nYou can have it for only $" +
						guitar.GetPrice() + "!\n");
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
