namespace Bridge
{
    public class Car : Vehicle
    {
        private string _liscense;
        public string Liscenseplate { get; set; }
        public DateTime Date { get; set; }

		/// <summary>
		/// Constructor for the instanciation of the Car object
		/// </summary>
		/// <param name="liscenseplate"></param>
		public Car(string liscenseplate) : base(liscenseplate)
		{
            Liscenceplate = liscenseplate;
            Date = DateTime.Today;
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
