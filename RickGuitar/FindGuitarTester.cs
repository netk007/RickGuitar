using System;

namespace RickGuitar
{
	public class FindGuitarTester
	{
		public static void Main(string[] args) {
			Inventory inventory = new Inventory();
			InitializeInventory(inventory);

			Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocastor", "electric", "Alder", "Alder");

			Guitar guitar = inventory.Search(whatErinLikes);

			if (guitar != null) {
				Console.WriteLine("Erin, you might like this " +
					guitar.GetBuilder() + " " + guitar.GetModel() + " " +
					guitar.GetType() + " guitar:\n " +
					guitar.GetBackWood() + " back and sides,\n " +
					guitar.GetTopWood() + " top.\nYou can have it for only $" +
					guitar.GetPrice() + "!");
			}
			else {
				Console.WriteLine("Sorry, Erin, we have nothing for you.");
			}

		}

		public static void InitializeInventory(Inventory inventory) {
			inventory.AddGuitar("V96693", 1499.95, "Fender", "Stratocastor", "electric", "Alder", "Alder");
		}
	}
}
