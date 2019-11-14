using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    public class Autocade : Departament
    {
        Head headAuto;
        List<Car> listCars = new List<Car>();
        List<Garage> listGarages = new List<Garage>();

        public Autocade(string name, Adress adr,string universityName, Head headAuto) : base(name, adr, universityName)
       {
           this.headAuto = headAuto;
       }

        public override string ToString()
        {
            string carStr = "";
            foreach (Car car in listCars)
                carStr += (" " + car);
            string garageStr = "";
            foreach (Garage garage in listGarages)
                carStr += (" " + garage);

            return base.ToString() + " " + headAuto + " " + carStr + " " + garageStr;
        }

        bool CanBeAdded(Car car)
        {
            foreach (Car c in listCars)
            {
                if (c != null && c.Equals(car))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddCar(Car car)
        {
            if ((listCars.Count < 2) && this.CanBeAdded(car))
            {
                listCars.Add(car);
                Console.WriteLine("Adding " + car);
                return true;
            }
            return false;

        }

        bool CanBeAdded(Garage garage)
        {
            foreach (Garage gar in listGarages)
            {
                if (gar != null && gar.Equals(garage))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddGarage(Garage garage)
        {
            if ((listGarages.Count < 2) && this.CanBeAdded(garage))
            {
                listGarages.Add(garage);
                Console.WriteLine("Adding " + garage);
                return true;
            }
            return false;

        }



    }
}
