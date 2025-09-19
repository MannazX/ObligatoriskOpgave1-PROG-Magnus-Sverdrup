using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public class MC : Vehicle
	{
		#region Properties
		public string Liscenseplate { get; set; }
		public DateTime Date { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for the instanciation of the Car object 
		/// </summary>
		/// <param name="liscenseplate">type: string</param>
		public MC(string liscenseplate) : base(liscenseplate)
		{
			Liscenceplate = liscenseplate;
			Date = DateTime.Today;
		}

		#endregion

		#region Methods
		/// <summary>
		/// Method returning price for the MC to cross the bridge
		/// </summary>
		/// <returns>type: double</returns>
		public override double Price(bool brobizz)
		{
			double price = 120;
			if (brobizz)
			{
				return price - (price / 10);
			}
			else
			{
				return price;
			}
		}

		/// <summary>
		/// Method for returning vehicle type: MC
		/// </summary>
		/// <returns>type: string</returns>
		public override string VehicleType()
		{
			return "MC";
		}
		#endregion
	}
}
