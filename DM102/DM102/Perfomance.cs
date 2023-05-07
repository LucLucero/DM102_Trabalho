using System;

namespace DM102
{

	public class Perfomance : Fuel	
	{
		public double velocity;
		public double acceleration;
		public double fuelConsumption;
		public double autonomy;

		public Perfomance(double fuelLevel, string fuelType, double velocity, double acceleration, double fuelConsumption, double autonomy) : base (fuelLevel, fuelType)
		{

			this.velocity = velocity;
			this.acceleration = acceleration;
			this.fuelConsumption = fuelConsumption;
			this.autonomy = autonomy;

		}

		public double CalculatePerfomance()
		{
			//Calcular Performance do carro
			Console.WriteLine("Perfomance Boa/Ruim");
			double performance = 10; //valor simbolico em %
			return performance;
		}

	}

}
