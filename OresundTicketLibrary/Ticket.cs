using Bridge;

namespace OresundTicketLibrary
{
	public class Ticket
	{
		public double Price { get; set; }
		public Vehicle Vehicle { get; set; }

		public Ticket(Vehicle vehicle, bool brobizz)
		{
			Vehicle = vehicle;
			Price = vehicle.Price(brobizz);
		}

		public double TicketPrice()
		{
			return Price;
		}
	}
}
