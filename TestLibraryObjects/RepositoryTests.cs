using Bridge;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryObjects
{
	[TestClass]
	public sealed class RepositoryTests
	{
		[ExcludeFromCodeCoverage]
		[TestMethod]
		public void TestAddTicket()
		{
			// Arrange
			Vehicle car = new Car("88-YTX");
			Ticket ticket = new Ticket(DayOfWeek.Saturday, car, true);
			TicketRepository repo = new TicketRepository();

			// Act
			int countBefore = repo.Count;
			repo.Add(ticket);
			int countAfter = repo.Count;

			// Assert
			Assert.AreEqual(countBefore + 1, countAfter);

		}

		[ExcludeFromCodeCoverage]
		[TestMethod]
		public void TestGetAllTickets()
		{
			// Arrange
			Vehicle car = new Car("XC-922");
			Ticket t1 = new Ticket(DayOfWeek.Saturday, car, true);
			Ticket t2 = new Ticket(DayOfWeek.Sunday, car, true);
			Ticket t3 = new Ticket(DayOfWeek.Monday, car, true);
			TicketRepository repo = new TicketRepository();

			// Act
			int countBefore = repo.Count;
			repo.Add(t1);
			repo.Add(t2);
			repo.Add(t3);
			int countAfter = repo.Count;
			
			// Assert
			Assert.AreEqual(countBefore + 3, countAfter);

		}

		[ExcludeFromCodeCoverage]
		[TestMethod]
		public void TestGetByLiscenseplate()
		{
			// Arrange
			string lp1 = "KL-823";
			string lp2 = "XT-722";
			Vehicle car1 = new Car(lp1);
			Vehicle car2 = new Car(lp2);
			Ticket t1 = new Ticket(DayOfWeek.Saturday, car1, true);
			Ticket t2 = new Ticket(DayOfWeek.Sunday, car1, true);
			Ticket t3 = new Ticket(DayOfWeek.Sunday, car2, true);
			TicketRepository repo = new TicketRepository();

			// Act
			repo.Add(t1);
			repo.Add(t2);
			repo.Add(t3); // Different liscense plate 
			List<Ticket> tickets1 = repo.GetByLiscenseplate(lp1).ToList();
			List<Ticket> tickets2 = repo.GetByLiscenseplate(lp2).ToList();

			// Assert
			Assert.AreNotEqual(tickets1.Count, tickets2.Count); // Tickets with lp1: 2, Tickets with lp2: 1

		}
	}
}
