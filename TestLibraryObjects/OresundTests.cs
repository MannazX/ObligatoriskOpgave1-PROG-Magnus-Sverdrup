using Bridge;
using OresundTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryObjects
{
	[TestClass]
	public class OresundTests
	{
		[TestMethod]
		public void TestOresundCarPrice()
		{
			// Arrange
			Vehicle car = new OresundCar("XT-998");

			// Act
			double price = car.Price(false);

			// Assert
			Assert.AreEqual(price, 460);

		}

		[TestMethod]
		public void TestOresundCarVehicleType()
		{
			// Arrange
			Vehicle car = new OresundCar("XT-998");

			// Act
			string type = car.VehicleType();

			// Assert
			Assert.AreEqual(type, "Oresund Car");

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestLengthOresundCarLiscencePlate()
		{
			// Arrange
			string lp = "XT-998-RK"; // Exceeds 7 characters

			// Act
			Vehicle car = new OresundCar(lp);

			// Assert
			Assert.Fail();

		}

		[TestMethod]
		public void TestOresundMCPrice()
		{
			// Arrange
			Vehicle mc = new MC("RL-823");

			// Act
			double price = mc.Price(false);

			// Assert
			Assert.AreEqual(price, 235);

		}

		[TestMethod]
		public void TestOresundMCVehicleType()
		{
			// Arrange
			Vehicle mc = new MC("RL-823");

			// Act
			string type = mc.VehicleType();

			// Assert
			Assert.AreEqual(type, "Oresund MC");

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestLengthOresundMCLiscencePlate()
		{
			// Arrange
			string lp = "RL-823-XL"; // Exceeds 7 characters

			// Act
			Vehicle car = new OresundCar(lp);

			// Assert
			Assert.Fail();

		}

		[TestMethod]
		public void TestOresundCarBrobizz()
		{
			// Arrange
			OresundCar car = new OresundCar("UT-288-LR");

			// Act
			double price = car.Price(true);

			// Assert
			Assert.AreEqual(price, 178);

		}

		[TestMethod]
		public void TestOresundMCBrobizz()
		{
			// Arrange
			OresundMC mc = new OresundMC("KI-779-LR");

			// Act
			double price = mc.Price(true);

			// Assert
			Assert.AreEqual(price, 92);

		}
	}
}
