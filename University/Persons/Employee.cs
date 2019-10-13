using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Employee : Person
    {
        int salary;

        public Employee(string name1, string name2, int year, string departament, int salary) : base(name1, name2, departament, year)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + " " + salary;
        }
    }
}
