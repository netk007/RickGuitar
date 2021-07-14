using System;
using System.Collections.Generic;

namespace RickGuitar
{
	public class FindGuitarTester
	{
		public static void Main(string[] args) {
			Inventory inventory = new Inventory();
			InitializeInventory(inventory);

			GuitarSpec whatErinLikes = new GuitarSpec("Stratocastor", Builder.FENDER, Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);

			List<Instrument> instruments = inventory.Search(whatErinLikes);

			if (instruments.Count > 0) {
				Console.WriteLine("Erin, you might like this:\n");
				int count = 1;
				foreach (Instrument instrument in instruments) {
					Console.WriteLine(count + ".");
					if (instrument is Guitar)
					{
						Guitar guitar = (Guitar)instrument;
						GuitarSpec guitarSpec = (GuitarSpec)guitar.GetSpec();

						Console.WriteLine(guitar.GetSpec().GetBuilder() + " " + guitar.GetSpec().GetModel() + " " +
							guitar.GetSpec().GetType() + " guitar:\n " +
							guitar.GetSpec().GetBackWood() + " back and sides,\n " +
							guitar.GetSpec().GetTopWood() + " top.\n" +
							guitarSpec.GetNumStrings() + " strings.\nYou can have it for only $" +
							guitar.GetPrice() + "!\n");
					}
					else if (instrument is Mandolin)
					{
						Mandolin mandolin = (Mandolin)instrument;
						MandolinSpec mandolinSpec = (MandolinSpec)mandolin.GetSpec();

						Console.WriteLine(mandolin.GetSpec().GetBuilder() + " " + mandolin.GetSpec().GetModel() + " " +
							mandolin.GetSpec().GetType() + " mandolin:\n " +
							mandolin.GetSpec().GetBackWood() + " back and sides,\n " +
							mandolin.GetSpec().GetTopWood() + " top.\n" +
							mandolinSpec.GetStyle() + " style.\nYou can have it for only $" +
							mandolin.GetPrice() + "!\n");
					}
					count++;
				}
			}
			else {
				Console.WriteLine("Sorry, Erin, we have nothing for you.");
			}
		}

		public static void InitializeInventory(Inventory inventory)
		{
			inventory.AddInstrument(new Guitar("G0001", 1499.95, new GuitarSpec("Stratocastor", Builder.FENDER, Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12)));
			inventory.AddInstrument(new Guitar("G0002", 1549.95, new GuitarSpec("Stratocastor", Builder.MARTIN, Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12)));

			inventory.AddInstrument(new Mandolin("M0001", 1549.95, new MandolinSpec("Stratocastor", Builder.FENDER, Type.ELECTRIC, Wood.ALDER, Wood.ALDER, Style.A)));
			inventory.AddInstrument(new Mandolin("M0002", 1549.95, new MandolinSpec("Stratocastor", Builder.GIBSON, Type.ACOUSTIC, Wood.ALDER, Wood.ALDER, Style.F)));
		}
	}
}
