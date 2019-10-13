using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
   public class Garage
    {
        Adress addressGar;
        float squareGar;
        int numberGar;

      public Garage (Adress addressGar, float squareGar, int numberGar)
        {
            this.addressGar = addressGar;
            this.squareGar = squareGar;
            this.numberGar = numberGar;
        }


      public override bool Equals(object obj)
      {
          Garage garage = obj as Garage;
          return garage.addressGar.Equals(this.addressGar) && garage.squareGar.Equals(this.squareGar) && garage.numberGar == this.numberGar;
      }


      public override string ToString()
      {
          return numberGar + " " + addressGar + " " + squareGar;
      }
    }
}
