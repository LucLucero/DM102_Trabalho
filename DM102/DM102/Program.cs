using System;
using System.Collections.Generic;

namespace DM102
{
    class Program
    {
        static void Main(string[] args)

        {
             


            //Instanciando Classe Alerts
            Alerts alerta = new Alerts("Falha nível de Óleo", "2023/03/01", "Baixo nível de Óleo");
            Console.WriteLine(alerta.SendNotification());
            //Instanciando Classe User
            User user1 = new User("Luciano", "luciano-bob@hotmail.com", "senha123");
            user1.Login(user1);


            //Teste Adicionando pilotos
            List<Drivers> listDrivers = new List<Drivers>();
            Drivers driver = new Drivers("Luciano", 24, "newbie");
            driver.addDrivers(listDrivers, driver);
            Drivers driver2 = new Drivers("Beatriz", 24, "expert");
            driver2.addDrivers(listDrivers, driver2);
            //Teste Adicionando um piloto já existente
            Drivers driver3 = new Drivers("Beatriz", 24, "expert");
            driver3.addDrivers(listDrivers, driver3);

            //Registrando uma manutenção
            Maintenance pedidoDeManutencao = new Maintenance("Troca de Pneu", "R$300", DateTime.Now);
            pedidoDeManutencao.RegisterMaintenance();

            //Instanciando uma location
            Location location = new Location("66 33 N", "30 10 E");
            location.UpdadeLocation();

            //Instanciando Travel
            List<Travel> listTravels = new List<Travel>();
            Travel travel = new Travel("66 33 N", "30 10 E", DateTime.Now, "Volta Redonda", "Mogi Guaçu", 105.0f, TimeSpan.Zero, 1);
            travel.RegisterTrip(listTravels, travel);
            travel.GetLocation(location);

            //Instanciando uma Rota
            Routes rota = new Routes("66 33 N", "30 10 E", DateTime.Now, "Volta Redonda", "Mogi Guaçu", 105.0f, TimeSpan.Zero, 1);
            rota.CalculateRoute();
            travel.getOldTrips(listTravels, travel);

            //Instanciando Veiculo
            Vehicle carro = new Vehicle(50,"aditivada", 200, 100, 8, 10,"C3", "AH2167SH178", 2015);
            Console.WriteLine(carro.GetInfo());

            //Instanciando Fuel
            Fuel fuel = new Fuel(50, "aditivada");
            carro.updateAutonomy();

            //Instanciando Performance
            Perfomance perfomance = new Perfomance(50, "aditivada", 200, 100, 8, 10);
            carro.CalculatePerfomance();





        } 
    }
}
