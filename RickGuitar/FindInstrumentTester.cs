using System;
using System.Collections.Generic;

namespace RickGuitar
{
	public class FindInstrumentTester
	{
		public static void Main(string[] args) {
			Inventory inventory = new Inventory();
			InitializeInventory(inventory);

			IDictionary<string, object> properties = new Dictionary<string, object>();
			properties.Add("builder", Builder.GIBSON);
			properties.Add("backWood", Wood.MAHOGANY);
			InstrumentSpec clientSpec = new InstrumentSpec(properties);

			List<Instrument> instruments = inventory.Search(clientSpec);

			if (instruments.Count > 0) {
				//Console.WriteLine("Hello, you might like this:\n");
				foreach (Instrument instrument in instruments)
				{
					Console.WriteLine("We have a " + instrument.GetSpec().GetProperties()["instrumentType"] + " with following properties:\n");

					foreach (KeyValuePair<string, object> i in instrument.GetSpec().GetProperties())
					{
						if (i.Key == "instrumentType")
							continue;

						Console.WriteLine("    " + i.Key + ": " + i.Value + "\n");
					}
					Console.WriteLine("You can have this " + instrument.GetSpec().GetProperties()["instrumentType"] + " for $" + instrument.GetPrice() + "\n---");
				}
			}
			else {
				Console.WriteLine("Sorry, we have nothing for you.");
			}
		}

		public static void InitializeInventory(Inventory inventory)
		{
			IDictionary<string, object> properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.GUITAR },
				{"builder", Builder.COLLIONGS },
				{"model", "CJ" },
				{"type", Type.ACOUSTIC},
				{"numStrings", 6},
				{"topWood", Wood.INDIAN_ROSEWOOD},
				{"backWood", Wood.SITKA},
			};
			inventory.AddInstrument(new Instrument("11277", 3999.95, new InstrumentSpec(properties)));

			properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.GUITAR },
				{"builder", Builder.MARTIN },
				{"model", "D-18" },
				{"topWood", Wood.MAHOGANY},
				{"backWood", Wood.ADIRONDACK},
			};
			inventory.AddInstrument(new Instrument("122784", 5495.95, new InstrumentSpec(properties)));

			properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.GUITAR },
				{"builder", Builder.FENDER },
				{"model", "Stratocastor" },
				{"type", Type.ELECTRIC},
				{"numStrings", 6},
				{"topWood", Wood.ALDER},
				{"backWood", Wood.ALDER},
			};
			inventory.AddInstrument(new Instrument("V95693", 1499.95, new InstrumentSpec(properties)));
			inventory.AddInstrument(new Instrument("V9512", 1549.95, new InstrumentSpec(properties)));

			properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.GUITAR },
				{"builder", Builder.FENDER },
				{"model", "Les Paul" },
				{"type", Type.ACOUSTIC},
				{"numStrings", 6},
				{"topWood", Wood.MAPLE},
				{"backWood", Wood.MAPLE},
			};
			inventory.AddInstrument(new Instrument("70108276", 2295.95, new InstrumentSpec(properties)));

			properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.GUITAR },
				{"builder", Builder.GIBSON },
				{"model", "SG ‘61 Reissue" },
				{"type", Type.ACOUSTIC},
				{"numStrings", 6},
				{"topWood", Wood.MAHOGANY},
				{"backWood", Wood.MAHOGANY},
			};
			inventory.AddInstrument(new Instrument("82765501", 1890.95, new InstrumentSpec(properties)));

			properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.MANDOLIN },
				{"builder", Builder.GIBSON },
				{"model", "SG ‘61 Reissue" },
				{"type", Type.ACOUSTIC},
				{"topWood", Wood.MAHOGANY},
				{"backWood", Wood.MAHOGANY},
			};
			inventory.AddInstrument(new Instrument("9019920", 5495.99, new InstrumentSpec(properties)));

			properties = new Dictionary<string, object> {
				{"instrumentType", InstrumentType.BANJO },
				{"builder", Builder.GIBSON },
				{"model", "RB-3 Wreath" },
				{"type", Type.ACOUSTIC},
				{"numStrings", 5},
				{"backWood", Wood.MAHOGANY},
			};
			inventory.AddInstrument(new Instrument("8900231", 2945.95, new InstrumentSpec(properties)));
		}
	}
}
