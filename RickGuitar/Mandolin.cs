using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitar
{
	public class Mandolin : Instrument
	{
		public Mandolin(string serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
		{
		}
	}
}
