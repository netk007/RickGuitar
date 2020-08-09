using System;

namespace RickGuitar
{
	public class Guitar
	{
		private string serialNumber;
		private string builder;
		private string model;
		private string type;
		private string backWood;
		private string topWood;
		private double price;

		public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood) {
			this.serialNumber = serialNumber;
			this.price = price;
			this.builder = builder;
			this.model = model;
			this.type = type;
			this.backWood = backWood;
			this.topWood = topWood;
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

		public string GetBuilder() {
			return builder;
		}

		public string GetModel() {
			return model;
		}

		public string GetType() {
			return type;
		}

		public string GetBackWood() {
			return backWood;
		}

		public string GetTopWood() {
			return topWood;
		}
	}
}
