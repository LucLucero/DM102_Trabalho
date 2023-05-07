using System;

public class Maintenance
{
	private string serviceType;
	private string cost;
	private DateTime dateTime;

	public Maintenance(string serviceType, string cost, DateTime dateTime)
	{
		this.serviceType = serviceType;
		this.cost = cost;
		this.dateTime = dateTime;
	}

	public void RegisterMaintenance()
    {

		Console.WriteLine("Manutenção Registrada");

    }






}
