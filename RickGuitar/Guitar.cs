using System;

namespace RickGuitar
{
	public class Guitar
	{
		private string serialNumber;
		private Builder builder;
		private string model;
		private Type type;
		private Wood backWood;
		private Wood topWood;
		private double price;

		public Guitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood) {
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

		public Builder GetBuilder() {
			return builder;
		}

		public string GetModel() {
			return model;
		}

		public new Type GetType() {
			return type;
		}

		public Wood GetBackWood() {
			return backWood;
		}

		public Wood GetTopWood() {
			return topWood;
		}
	}
}
