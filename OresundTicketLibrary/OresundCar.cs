using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary
{
	public class OresundCar : Vehicle
	{
		#region Properties
		public string Liscenseplate { get; set; }
		public DateTime Date { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for the instanciation of Oresund Car - Inheriting from Vehicle base class
		/// </summary>
		/// <param name="liscenseplate">type: string</param>
		public OresundCar(string liscenseplate) : base(liscenseplate)
		{
			Liscenceplate = liscenseplate;
			Date = DateTime.Today;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Overriding method from base class for returning the price with including brobizz discount if applicable
		/// </summary>
		/// <param name="brobizz">type: bool - condition if brobizz discount applies (condition true)</param>
		/// <returns>type: double</returns>
		public override double Price(bool brobizz)
		{
			double price = 460;
			if (brobizz)
			{
				price = 178;
			}
			return price;
		}

		/// <summary>
		/// Overriding Method from base class for returning the vehicle type
		/// </summary>
		/// <returns>type: string</returns>
		public override string VehicleType()
		{
			return "Oresund Car";
		}
		#endregion
	}
}
