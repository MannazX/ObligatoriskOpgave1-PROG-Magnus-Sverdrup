using Bridge;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryObjects
{
	[TestClass]
	public sealed class RepositoryTests
	{
		[TestMethod]
		public void TestAddTicket()
		{
			// Arrange
			Vehicle car = new Car("88-YTX");
			Ticket ticket = new Ticket(DayOfWeek.Saturday, car, true);
			TicketRepository repo = new TicketRepository();

			// Act
			repo.Add(ticket);
			int check = 1; // Number of items added to the list - Ans: 1

			// Assert
			Assert.AreEqual(check, repo.Count);

		}

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
			repo.Add(t1);
			repo.Add(t2);
			repo.Add(t3);
			List<Ticket> tickets = repo.GetAll();
			int check = 3; // Number of items added to the list - Ans: 3

			// Assert
			Assert.AreEqual(check, tickets.Count);

		}

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
			repo.Add(t3);
			List<Ticket> tickets = repo.GetByLiscenseplate(lp1).ToList();
			
			// Assert
			Assert.AreNotEqual(repo.Count, tickets.Count); // Repository: 3, Tickets Retrieved by Liscense Plate: 2

		}
	}
}
