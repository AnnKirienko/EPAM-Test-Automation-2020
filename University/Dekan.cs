using System;

namespace University
{
    class Dekan : Person
    {
        string degree;

        public Dekan (string name1, string name2, string degr) 
        {
            firstName = name1;
            secondName = name2;
            degree = degr;
        }
    }
}
