using System;

namespace DEV_6
{
    public class Car
    {
        string model;
        int number;
        string mark;
        double cost;

        public string Model { get => model; set => model = value; }
        public int Number { get => number; set => number = value; }
        public string Mark { get => mark; set => mark = value; }
        public double Cost { get => cost; set => cost = value; }

        public Car(string mod, int num, string mark, double cost)
        {
            mod = Model;
            num = Number;
            mark = Mark;
            cost = Cost;
        }       
    }
}
