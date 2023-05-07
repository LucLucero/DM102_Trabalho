using System;
using System.Collections.Generic;
using DM102;

namespace DM102{

    public class Travel : Location
    {
        private DateTime dateTime;
        private string origin;
        private string destination;
        private double totalDistance;
        private TimeSpan tripTime;
        private int tripID;

        public Travel(string latitude, string longitude, DateTime dateTime, string origin, string destination, double totalDistance, TimeSpan tripTime, int tripID) : base(latitude, longitude)
        {
            this.dateTime = dateTime;
            this.origin = origin;
            this.destination = destination;
            this.totalDistance = totalDistance;
            this.tripTime = tripTime;
            this.tripID = tripID;
        }

        public void RegisterTrip(List<Travel> listTrips, Travel trip)
        {

            if (listTrips == null)
            {
                listTrips = new List<Travel>();
            }

            if (trip == null)
            {
                throw new ArgumentNullException(nameof(trip));
            }

            if (listTrips.Exists(tr => tr.tripID == trip.tripID))
            {
                Console.WriteLine("Viagem já cadastrada");
            }
            else
            {
                listTrips.Add(trip);
                
                Console.WriteLine("Viagem adicionado na lista");

            }
            

        }


        public string GetLocation(Location location)
        {

          return $"Localização atual {latitude} - {longitude}";

        }

        public void getOldTrips(List<Travel> listTrips, Travel trip)
        {

            foreach (var tr in listTrips)
            {
                Console.WriteLine(tr.tripID);
            }
        }


    }


}


