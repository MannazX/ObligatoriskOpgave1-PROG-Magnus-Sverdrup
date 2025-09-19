using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
	public class TicketRepository : ITicketRepository
	{
		private static List<Ticket> _tickets;
		private static int _count = 0;

		public int Count { get { return _count; } }

		public TicketRepository()
		{
			_tickets = new List<Ticket>();
		}

		#region Create
		public void Add(Ticket ticket)
		{
			_tickets.Add(ticket);
			_count++;
		}

		#endregion

		#region Read
		public List<Ticket> GetAll()
		{
			return _tickets;
		}

		public IEnumerable<Ticket> GetByLiscenseplate(string? liscenseplate = null)
		{
			IEnumerable<Ticket> ticketList = _tickets;
			if (liscenseplate != null)
			{
				ticketList = ticketList.Where(x => x.Vehicle.Liscenceplate == liscenseplate);
			}
			return ticketList;
		}

		#endregion

	}
}
