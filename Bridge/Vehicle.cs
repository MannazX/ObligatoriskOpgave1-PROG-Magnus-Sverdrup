using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public abstract class Vehicle
	{
		private string _liscenceplate;

		public string Liscenceplate { get; set; }

		public Vehicle(string liscenseplate)
		{
			if (liscenseplate.Length > 7)
			{
				throw new ArgumentException("The liscense plate cannot exceed 7 characters");
			}
		}

		public abstract double Price(bool brobizz);
		public abstract string VehicleType();

	}
}
