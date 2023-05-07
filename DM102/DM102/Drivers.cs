using System;
using System.Collections.Generic;

namespace DM102
{

    public class Drivers
    {

        private string name;
        private int age;
        private string experience;
        

        public Drivers(string name, int age, string experience)
        {
            this.name = name;
            this.age = age;
            this.experience = experience;

        }

        public void addDrivers(List<Drivers> listaDrivers, Drivers driver)
        {
            if (listaDrivers == null)
            {
                listaDrivers = new List<Drivers>();
            }

            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "O piloto não pode ser nulo.");
            }

            if (listaDrivers.Exists(d => d.name == driver.name))
            {
                Console.WriteLine("Já existe");
            }
            else
            {
                listaDrivers.Add(driver);                
                Console.WriteLine("Piloto adicionado na lista");
                Console.WriteLine("Lista de pilotos atualizada:");
                foreach (var d in listaDrivers)
                {
                    Console.WriteLine(d.name);
                }

            }
        }




    }
}
