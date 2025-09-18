using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryObjects
{
	[TestClass]
	public sealed class MCTests
	{
		[TestMethod]
		public void TestMCPrice()
		{
			// Arrange
			Vehicle car = new MC("832-RT");

			// Act
			double price = car.Price(false); // Price without brobizz
			double res = 120;

			// Assert
			Assert.AreEqual(price, res);

		}

		[TestMethod]
		public void TestMCVehicleType()
		{
			// Arrange
			Vehicle car = new MC("832-RT");

			// Act
			string vehicle = car.VehicleType();
			string res = "MC";

			// Assert
			Assert.AreEqual(vehicle, res);

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestLengthOfMCLiscensePlate()
		{
			// Arrange 
			string lp = "832-RT-9RK"; // Exceeds 7 characters

			// Act
			Vehicle mc = new MC(lp);

			// Assert
			Assert.Fail();

		}

		[TestMethod]
		public void TestMCBrobizz()
		{
			// Arrange
			Vehicle mc = new MC("888-YT");

			// Act
			double price = mc.Price(true);

			// Assert
			Assert.AreEqual(price, 108);

		}
	}
}
