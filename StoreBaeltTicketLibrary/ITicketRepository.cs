
namespace StoreBaeltTicketLibrary
{
	public interface ITicketRepository
	{
		int Count { get; }

		void Add(Ticket ticket);
		List<Ticket> GetAll();
		IEnumerable<Ticket> GetByLiscenseplate(string? liscenseplate = null);
	}
}