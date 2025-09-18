using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary
{
	public class OresundMC : Vehicle
	{
		public string Liscenseplate { get; set; }
		public DateTime Date { get; set; }

		public OresundMC(string liscenseplate) : base(liscenseplate)
		{
			Liscenceplate = liscenseplate;
			Date = DateTime.Today;
		}

		public override double Price(bool brobizz)
		{
			double price = 235;
			if (brobizz)
			{
				price = 92;
			}
			return price;
		}
		public override string VehicleType()
		{
			return "Oresund MC";
		}
	}
}
