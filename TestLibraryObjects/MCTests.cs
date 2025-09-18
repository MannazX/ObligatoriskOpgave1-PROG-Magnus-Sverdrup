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
			MC car = new MC("832-RT", new DateTime(2025, 9, 1));

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
			MC car = new MC("832-RT", new DateTime(2025, 9, 1));

			// Act
			string vehicle = car.VehicleType();
			string res = "MC";

			// Assert
			Assert.AreEqual(vehicle, res);

		}
	}
}
