using System;

namespace RickGuitar
{
	public class Guitar
	{
		private string serialNumber;
		private double price;
		private GuitarSpec spec;

		public Guitar(string serialNumber, double price, GuitarSpec spec)
		{
			this.serialNumber = serialNumber;
			this.price = price;
			this.spec = spec;
		}

		public string GetSerialNumber() {
			return serialNumber;
		}

		public double GetPrice() {
			return price;
		}

		public void SetPrice(double price) {
			this.price = price;
		}

		public GuitarSpec GetSpec() {
			return this.spec;
		}
	}
}
