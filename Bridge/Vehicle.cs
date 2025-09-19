using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public abstract class Vehicle
	{
		#region Instance Fields
		private string _liscenceplate;
		#endregion

		#region Properties
		public string Liscenceplate { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for the Vehicle base class, implementing exception cases for all inheriting subclasses
		/// </summary>
		/// <param name="liscenseplate">type: string</param>
		/// <exception cref="ArgumentException">Exception for handling arguments with string length above 7</exception>
		public Vehicle(string liscenseplate)
		{
			if (liscenseplate.Length > 7)
			{
				throw new ArgumentException("The liscense plate cannot exceed 7 characters");
			}
		}

		#endregion

		#region Methods
		/// <summary>
		/// Abstract Method for the inheriting subclasses to implement for returning the price for crossing bridges
		/// </summary>
		/// <param name="brobizz">type: bool - Condition for providing brobizz discoun (condition true)</param>
		/// <returns>type: double</returns>
		public abstract double Price(bool brobizz);

		/// <summary>
		/// Abstract Method for the inheriting subclasses to implement for returning the vehicle type
		/// </summary>
		/// <returns>type: double</returns>
		public abstract string VehicleType();

		#endregion

	}
}
