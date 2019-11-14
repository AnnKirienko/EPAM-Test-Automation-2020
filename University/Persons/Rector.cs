using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    public class Rector : Person
    {
        public Rector(string name1, string name2, int year, string departament) : base(name1, name2, departament, year)
        {

        }

        public Rector()
        { }
    }
}
