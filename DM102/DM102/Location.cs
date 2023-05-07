using System;

namespace DM102
{
	public class Location
	{
		public string latitude;
		public string longitude;

		public Location(string latitude, string longitude)
		{
			this.latitude = latitude;
			this.longitude = longitude;


		}

		public void UpdadeLocation()
		{

			Console.WriteLine("Localização Atualizada");

		}

	}

}

