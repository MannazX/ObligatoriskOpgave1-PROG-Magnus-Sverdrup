using Bridge;

namespace OresundTicketLibrary
{
	public class Ticket
	{
		#region Properties
		public double Price { get; set; }
		public Vehicle Vehicle { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for instanciation of tickets for Oresundsbroen
		/// </summary>
		/// <param name="vehicle">type: Vehicle - represents the vehicle that crosses the bridge</param>
		/// <param name="brobizz">type: bool - condition determining if there is brobizz discount (condition true)</param>
		public Ticket(Vehicle vehicle, bool brobizz)
		{
			Vehicle = vehicle;
			Price = vehicle.Price(brobizz);
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
