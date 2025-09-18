namespace Bridge
{
    public class Car : Vehicle
    {
        public string Liscenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Constructor for the instanciation of the Car object
        /// </summary>
        /// <param name="liscenseplate">type: string - Liscence plate for the car</param>
        /// <param name="date">type: DateTime - Date for the car registered to cross the bridge</param>
		public Car(string liscenseplate, DateTime date)
		{
            Liscenseplate = liscenseplate;
            Date = date;
		}

        /// <summary>
        /// Price for the car to cross the bridge
        /// </summary>
        /// <returns>type: double - Price of a bridge ticket</returns>
		public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Vehicle Type of the vehicle crossing the bridge
        /// </summary>
        /// <returns>type: string - Name of vehicle type</returns>
        public override string VehicleType()
        {
            return "Car";
        }
	}
}
