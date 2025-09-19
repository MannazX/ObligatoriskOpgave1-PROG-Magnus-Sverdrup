using Bridge;

namespace StoreBaeltTicketLibrary
{
	public class Ticket
	{
		#region Properties
		public DayOfWeek Date { get; set; }
		public Vehicle Vehicle { get; set; }
		public double Price { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor - Tickets for Vehicles on Storebaeltsbroen, ensures that the weekend discount only works for cars
		/// </summary>
		/// <param name="date">type: DayOfWeek - represents the day of week the car is crossing the bridge</param>
		/// <param name="vehicle">type: Vehicle - represents the vehicle that crosses the bridge</param>
		/// <param name="brobizz">type: bool - condition determining if there is brobizz discount (condition true)</param>
		public Ticket(DayOfWeek date, Vehicle vehicle, bool brobizz)
		{
			if (vehicle.GetType() == typeof(Car))
			{
				if (date == DayOfWeek.Saturday || date == DayOfWeek.Sunday)
				{
					double weekendDiscount = vehicle.Price(false) * 0.15;
					double brobizzDiscount = 0;
					if (brobizz)
					{
						brobizzDiscount = vehicle.Price(false) * 0.1;
					}
					Price = vehicle.Price(false) - weekendDiscount - brobizzDiscount;
				}
				else
				{
					Price = vehicle.Price(brobizz);
				}
			}
			else
			{
				Price = vehicle.Price(brobizz);
			}
			Date = date;
			Vehicle = vehicle;
		}

		#endregion

		#region Methods
		/// <summary>
		/// Method for returning the ticket price
		/// </summary>
		/// <returns>type: double</returns>
		public double TicketPrice()
		{
			return Price;
		}
		#endregion
	}
}
