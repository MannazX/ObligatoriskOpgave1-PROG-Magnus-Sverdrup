namespace Bridge
{
    public class Car : Vehicle
    {
		#region Properties
		public string Liscenseplate { get; set; }
        public DateTime Date { get; set; }

		#endregion

		#region Constructor
		/// <summary>
		/// Constructor for the instanciation of the Car object
		/// </summary>
		/// <param name="liscenseplate">type: string - Liscense plate for a vehicle crossing the bridge</param>
		public Car(string liscenseplate) : base(liscenseplate)
		{
            Liscenceplate = liscenseplate;
            Date = DateTime.Today;
		}

		#endregion

		#region Methods
		/// <summary>
		/// Method for returning price for the car to cross the bridge
		/// </summary>
		/// <returns>type: double</returns>
		public override double Price(bool brobizz)
        {
            double price = 230;
            if (brobizz)
            {
                return price - (price / 10);
            }
            else
            {
                return price;
            }
        }

        /// <summary>
        /// Method for returing vehicle type: Car
        /// </summary>
        /// <returns>type: string - Name of vehicle type</returns>
        public override string VehicleType()
        {
            return "Car";
        }
		#endregion
	}
}
