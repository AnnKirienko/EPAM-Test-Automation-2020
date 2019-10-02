using System;

namespace University
{
    public class Dekan : Person
    {
        string degree;

        public Dekan (string name1, string name2, int year, string degr) : base(name1, name2, year)
        {
            degree = degr;
        }

        public override string ToString()
        {
            return base.ToString() + " " + degree;
        }
    }
}
