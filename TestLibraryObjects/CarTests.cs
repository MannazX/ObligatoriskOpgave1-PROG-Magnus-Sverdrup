using Bridge;

namespace TestLibraryObjects
{
	[TestClass]
	public sealed class CarTests
	{
		[TestMethod]
		public void TestCarPrice()
		{
			// Arrange
			Vehicle car = new Car("239-XC");

			// Act
			double price = car.Price(false); // Price without brobizz
			double res = 230;

			// Assert
			Assert.AreEqual(price, res);

		}

		[TestMethod]
		public void TestCarVehicleType()
		{
			// Arrange
			Vehicle car = new Car("239-XC");

			// Act
			string vehicle = car.VehicleType();
			string res = "Car";

			// Assert
			Assert.AreEqual(vehicle, res);

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestLengthOfCarLiscencePlate()
		{
			// Arrange
			string lp = "832-RT-9RK"; // Exceeds 7 characters

			// Act
			Vehicle car = new Car(lp);

			// Assert
			Assert.Fail();

		}

		[TestMethod]
		public void TestCarBrobizz()
		{
			// Arrange
			Vehicle car = new Car("999-KT");

			// Act
			double price = car.Price(true);
			double result = 207;
			double delta = price - result;

			// Assert
			Assert.AreEqual(price, result, delta);

		}
	}
}
