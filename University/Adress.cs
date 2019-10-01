using System;

namespace University
{
    class Adress
    {
       public string cityAdr;
       public string streetAdr;
       public string buildingAdr;

        public Adress (string cA, string sA, string bA ) 
       {
           cityAdr = cA;
           streetAdr = sA;
           buildingAdr = bA;
       }


       public string GetAdress(string city, string street, string building)
       {
           string fullAdress = cityAdr + streetAdr + cityAdr;
           cityAdr = city;
           streetAdr = street;
           buildingAdr = building;
           cityAdr = city;
           return (fullAdress);
           
       }



    }
}
