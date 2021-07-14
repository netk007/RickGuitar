using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitar
{
	public abstract class Instrument
	{
		private string serialNumber;
		private double price;
		private InstrumentSpec spec;

		public Instrument(string serialNumber, double price, InstrumentSpec spec)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.spec = spec;
		}

		public string GetSerialNumber()
		{
			return serialNumber;
		}

		public double GetPrice()
		{
			return price;
		}

		public void SetPrice(double price)
		{
			this.price = price;
		}

		public InstrumentSpec GetSpec()
		{
			return spec;
		}
	}
}
