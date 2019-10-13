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
    

       public override string ToString()
       {
           return this.cityAdr + ", " + this.streetAdr + ", " + this.buildingAdr;
       }



    }
}
