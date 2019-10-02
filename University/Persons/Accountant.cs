using System;

namespace University
{
   public class Accountant : Person
    {
        string position;

        public Accountant(string name1, string name2, int year, string position) : base(name1, name2, year)
        {
            this.position = position;
        }

        public override string ToString()
        {
            return base.ToString() + " " + position;
        }
    }
}
