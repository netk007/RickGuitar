using System;
using System.Collections.Generic;

namespace RickGuitar
{
	public class FindGuitarTester
	{
		public static void Main(string[] args) {
			Inventory inventory = new Inventory();
			InitializeInventory(inventory);

			Guitar whatErinLikes = new Guitar("", 0, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);

			List<Guitar> guitars = inventory.Search(whatErinLikes);

			if (guitars.Count > 0) {
				Console.WriteLine("Erin, you might like this:\n");
				int count = 1;
				foreach (Guitar guitar in guitars) {
					Console.WriteLine(count + ".\n");
					Console.WriteLine(guitar.GetBuilder() + " " + guitar.GetModel() + " " +
						guitar.GetType() + " guitar:\n " +
						guitar.GetBackWood() + " back and sides,\n " +
						guitar.GetTopWood() + " top.\nYou can have it for only $" +
						guitar.GetPrice() + "!");

					count++;
				}
			}
			else {
				Console.WriteLine("Sorry, Erin, we have nothing for you.");
			}

		}

		public static void InitializeInventory(Inventory inventory) {
			inventory.AddGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
			inventory.AddGuitar("V9512", 1549.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
		}
	}
}
