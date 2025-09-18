using Bridge;

namespace StoreBaeltTicketLibrary
{
	public class Ticket
	{
		public DayOfWeek Date { get; set; }
		public Vehicle Car { get; set; }
		public double Price { get; set; }
		public bool Brobizz { get; set; }
		

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
			
		}

		public double TicketPrice()
		{
			return Price;
		}
	}
}
