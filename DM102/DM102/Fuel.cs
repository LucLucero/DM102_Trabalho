using System;

namespace DM102
{

	public class Fuel
	{
		public double fuelLevel;
		
		public string fuelType;

		public Fuel(double fuelLevel, string fuelType)
		{

			this.fuelLevel = fuelLevel;			
			this.fuelType = fuelType;

		}

		public void updateAutonomy()
        {
			//Atualizar status de Autonomia
			Console.WriteLine("Atualizar Autonomia");

        }

	}

}

