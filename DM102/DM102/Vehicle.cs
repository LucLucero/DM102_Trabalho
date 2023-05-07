using System;
namespace DM102
{
	public class Vehicle : Perfomance
	{
		private string model;
		private string chassiNumber;
		private int year;


		public Vehicle(double fuelLevel, string fuelType, double velocity, double acceleration, double fuelConsumption, double autonomy, string model, string chassiNumber, int year) : base(fuelLevel, fuelType, velocity, acceleration, fuelConsumption, autonomy)
		{
			this.model = model;
			this.chassiNumber = chassiNumber;
			this.year = year;
		}

		public string GetInfo()
        {

			return $"Veículo é do modelo: {model}" +
				$" e do ano : {year}" +
				$" Perfomance: " +
				$" Consumo de combustível: {fuelConsumption}" +
				$" Nível Combustível {fuelLevel}" +
				$" Velocidade: {velocity}" +
				$" Aceleração: {acceleration}" +
				$" Autonomia: {autonomy}";
				


		}


	}


}
