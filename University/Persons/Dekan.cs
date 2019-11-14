using Newtonsoft.Json;
using System;

namespace University
{
    public class Dekan : Person
    {
        string degree;

        public Dekan (string name1, string name2, int year, string departament, string degr) : base(name1, name2, departament, year)
        {
            degree = degr;
        }

        public string Degree { get => degree; set => degree = value; }

        public override string ToString()
        {
            return base.ToString() + " " + degree;
        }
    }
}
