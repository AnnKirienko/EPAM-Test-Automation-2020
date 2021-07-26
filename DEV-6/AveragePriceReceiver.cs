using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_6
{
    public class AveragePriceReceiver
    {
        public void PrintAveragePrice(List<Car> list)
        {
            Console.WriteLine("Average Price = ", CalculateAveragePrice(list));
        }

        private double CalculateAveragePrice(List<Car> list)
        {
            return GetPriceOfCar(list).Average();
        }

        private List<double> GetPriceOfCar(List<Car> list)
        {

            List<double> selectedPriceOfCar = new List<double>(from car in list
                                                               select car.Cost);

            return selectedPriceOfCar;
        }
    }
}
