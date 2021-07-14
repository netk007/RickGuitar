using System.Collections.Generic;
using System.Security;

namespace RickGuitar
{
	public class Inventory
	{
		private List<Instrument> inventory;

		public Inventory() {
			inventory = new List<Instrument>();
		}

		public void AddInstrument(Instrument instrument)
		{
			inventory.Add(instrument);
		}

		public Instrument GetInstrument(string serialNumber)
		{
			foreach (Instrument instrument in inventory)
			{
				Instrument actualInstrument = (Instrument)instrument;
				if (actualInstrument.GetSerialNumber().Equals(serialNumber))
				{
					return instrument;
				}
			}
			return null;
		}

		public List<Instrument> Search(GuitarSpec searchSpec)
		{
			List<Instrument> matchedInstrument = new List<Instrument>();

			foreach (Instrument instrument in inventory)
			{
				if(instrument is Guitar && instrument.GetSpec().Equals(searchSpec))
					matchedInstrument.Add(instrument);
			}
			return matchedInstrument;
		}

		public List<Instrument> Search(MandolinSpec searchSpec)
		{
			List<Instrument> matchedInstrument = new List<Instrument>();

			foreach (Instrument instrument in inventory)
			{
				if (instrument is Mandolin && instrument.GetSpec().Equals(searchSpec))
					matchedInstrument.Add(instrument);
			}
			return matchedInstrument;
		}
	}
}
