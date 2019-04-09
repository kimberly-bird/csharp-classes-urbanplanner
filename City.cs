using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        /*
        Name of the city.
        The mayor of the city.
        Year the city was established.
        A collection of all of the buildings in the city.
        A method to add a building to the city.
        */

        private string _cityName { get; set; }
        private int _yearEstablished { get; set; }
        public string Mayor { get; set; }
        public List<Building> AllBuildings = new List<Building>();

        public City (string cityName, int yearEstablished) {
            _cityName = cityName;
            _yearEstablished = yearEstablished;
        }

        public void AddBuilding(Building building) {
            AllBuildings.Add(building);
        }
        
    }

}