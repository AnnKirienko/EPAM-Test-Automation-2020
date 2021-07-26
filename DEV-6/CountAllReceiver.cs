using System;
using System.Collections.Generic;

namespace DEV_6
{
   public class CountAllReceiver
    {
        public void PrintCountAll(List<Car> list)
        {
            Console.WriteLine("Average Price = ", CalculateCountAll(list));
        }

        private double CalculateCountAll(List<Car> list)
        {
            return list.Count;
        }
    }
}
