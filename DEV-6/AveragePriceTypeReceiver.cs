using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_6
{
  public class AveragePriceTypeReceiver
    {   
       public void PrintAveragePriceType(string type, List<Car> list)
        {
            Console.WriteLine("Average Price by Type = ", CalculateAveragePriceType(type, list));
        }

       private double CalculateAveragePriceType(string type, List<Car> list)
        {
           return GetPriceOfCarByType(type, list).Average();
        }

        private List<double> GetPriceOfCarByType(string type, List<Car> list)
        {

            List<double> selectedPriceOfCarByMarks = new List<double> (from car in list
                                       where car.Mark == type
                                       select car.Cost);

            return selectedPriceOfCarByMarks;
        }
    }
}
