using Newtonsoft.Json;
using System;

namespace University
{
    public class Adress
    {
        string cityAdr;
        string streetAdr;
        string buildingAdr;

        public Adress (string cA, string sA, string bA ) 
       {
           cityAdr = cA;
           streetAdr = sA;
           buildingAdr = bA;
       }

        public string CityAdr { get => cityAdr; set => cityAdr = value; }
        public string StreetAdr { get => streetAdr; set => streetAdr = value; }
        public string BuildingAdr { get => buildingAdr; set => buildingAdr = value; }

        public override string ToString()
       {
           return this.cityAdr + ", " + this.streetAdr + ", " + this.buildingAdr;
       }



    }
}
