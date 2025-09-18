using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public class MC : Vehicle
	{
		public string Liscenseplate { get; set; }
		public DateTime Date { get; set; }

		/// <summary>
		/// Constructor for the instanciation of the Car object 
		/// </summary>
		/// <param name="liscenseplate"></param>
		public MC(string liscenseplate) : base(liscenseplate)
		{
			Liscenceplate = liscenseplate;
			Date = DateTime.Today;
		}

		/// <summary>
		/// Price for the MC to cross the bridge
		/// </summary>
		/// <returns></returns>
		public override double Price()
		{
			return 120;
		}

		/// <summary>
		/// Vehicle Type for the vehicle crossing the bridge
		/// </summary>
		/// <returns></returns>
		public override string VehicleType()
		{
			return "MC";
		}

	}
}
