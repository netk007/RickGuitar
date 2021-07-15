using System.Collections.Generic;

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
				if (instrument.GetSerialNumber().Equals(serialNumber))
				{
					return instrument;
				}
			}
			return null;
		}

		public List<Instrument> Search(InstrumentSpec searchSpec)
		{
			List<Instrument> matchedInstrument = new List<Instrument>();
			foreach (Instrument instrument in inventory)
			{
				if(instrument.GetSpec().Equals(searchSpec))
					matchedInstrument.Add(instrument);
			}
			return matchedInstrument;
		}
	}
}
