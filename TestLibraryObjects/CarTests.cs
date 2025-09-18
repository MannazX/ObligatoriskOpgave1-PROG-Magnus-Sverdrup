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
			Vehicle car = new Car("239-XC", new DateTime(2025, 9, 1));

			// Act
			double price = car.Price();
			double res = 230;

			// Assert
			Assert.AreEqual(price, res);

		}

		[TestMethod]
		public void TestCarVehicleType()
		{
			// Arrange
			Vehicle car = new Car("239-XC", new DateTime(2025, 9, 1));

			// Act
			string vehicle = car.VehicleType();
			string res = "Car";

			// Assert
			Assert.AreEqual(vehicle, res);

		}
	}
}
