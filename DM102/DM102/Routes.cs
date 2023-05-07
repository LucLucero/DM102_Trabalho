using System;


namespace DM102
{
	public class Routes : Travel
	{
		public Routes(string latitude, string longitude, DateTime dateTime, string origin, string destination, double totalDistance,  TimeSpan tripTime, int tripId) : base(latitude, longitude, dateTime, origin, destination, totalDistance, tripTime, tripId)
		{


		}

		public void CalculateRoute()
        {

			//Calcular Rota
			Console.WriteLine("Rota Calculada");		

		}


	}

}

