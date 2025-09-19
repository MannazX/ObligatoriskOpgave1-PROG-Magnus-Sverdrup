using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
	public class TicketRepository : ITicketRepository
	{
		#region Instance Fields
		private static List<Ticket> _tickets;
		private static int _count = 0;
		#endregion

		#region Properties
		public int Count { get { return _count; } }
		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for instanciation of repoistory objects
		/// </summary>
		public TicketRepository()
		{
			_tickets = new List<Ticket>();
		}
		#endregion

		#region Methods
		/// <summary>
		/// Method for adding a ticket to the repository list, count is incremented when an item is added
		/// </summary>
		/// <param name="ticket">type: Ticket</param>
		public void Add(Ticket ticket)
		{
			_tickets.Add(ticket);
			_count++;
		}

		/// <summary>
		/// Method for getting all tickets in the list
		/// </summary>
		/// <returns>type: List<Ticket></returns>
		public List<Ticket> GetAll()
		{
			return _tickets;
		}

		/// <summary>
		/// Method for getting the tickets in the repository with a given liscense plate
		/// </summary>
		/// <param name="liscenseplate">type: string</param>
		/// <returns>type: IEnumerable<Ticket> - List of tickets with the liscense plate</returns>
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
