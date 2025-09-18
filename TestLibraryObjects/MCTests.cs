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
			double price = car.Price();
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
			Vehicle mc = new MC("832-RT-9RK");

			// Assert
			Assert.Fail();

		}
	}
}
