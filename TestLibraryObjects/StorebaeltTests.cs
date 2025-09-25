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
	public sealed class StorebaeltTests
	{
		[TestMethod]
		public void TestWeekendTicket()
		{
			// Arrange
			Vehicle car = new Car("88-YTX");
			Ticket ticket = new Ticket(DayOfWeek.Saturday, car, true);

			// Act
			double price = ticket.TicketPrice();
			double result = 17.95;
			double delta = price - result;

			// Assert
			Assert.AreEqual(price, result, delta);

		}

		[TestMethod]
		public void TestWeekdayTicket()
		{
			// Arrange
			Vehicle car = new Car("88-YTX");
			Ticket ticket = new Ticket(DayOfWeek.Monday, car, true);

			// Act
			double price = ticket.TicketPrice();
			
			// Assert
			Assert.AreEqual(price, 207);

		}
		
		[TestMethod]
		public void TestMCTicket()
		{
			// Arrange
			Vehicle mc = new MC("72-BXI");
			Ticket ticket = new Ticket(DayOfWeek.Sunday, mc, true);

			// Act
			double price = ticket.TicketPrice();

			// Assert
			Assert.AreEqual(price, 108);

		}
	}
}
