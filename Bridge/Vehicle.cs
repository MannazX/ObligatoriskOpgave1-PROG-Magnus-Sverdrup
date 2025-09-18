using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	public abstract class Vehicle
	{
		private string _liscenceplate;
		public string Liscenceplate
		{
			get { return _liscenceplate; } 
			set
			{
				if (_liscenceplate.Length > 7)
				{
					throw new ArgumentException("The liscense plate cannot be longer than 7 characters"); ;
				}
			}
		}
		public DateTime Date { get; set; }
		public abstract double Price();
		public abstract string VehicleType();

	}
}
