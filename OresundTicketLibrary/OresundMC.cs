using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary
{
	public class OresundMC : Vehicle
	{
		#region Properties
		public string Liscenseplate { get; set; }
		public DateTime Date { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for instanciation of Oresund MC - Inheritance of Vehicle base class
		/// </summary>
		/// <param name="liscenseplate">type: string</param>
		public OresundMC(string liscenseplate) : base(liscenseplate)
		{
			Liscenceplate = liscenseplate;
			Date = DateTime.Today;
		}

		#endregion

		#region Methods
		/// <summary>
		/// Method for returning the price with including brobizz discount if applicable 
		/// </summary>
		/// <param name="brobizz">type: bool - condition if brobizz discount applies (condition true)</param>
		/// <returns>type: double</returns>
		public override double Price(bool brobizz)
		{
			double price = 235;
			if (brobizz)
			{
				price = 92;
			}
			return price;
		}

		/// <summary>
		/// Method for returning the vehicle type 
		/// </summary>
		/// <returns>type: string</returns>
		public override string VehicleType()
		{
			return "Oresund MC";
		}
		#endregion
	}
}
