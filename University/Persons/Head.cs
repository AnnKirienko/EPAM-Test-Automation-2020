using System;


namespace University
{
   public class Head : Person
    {
        int experience;

        public Head (string name1, string name2, int year, int exp) : base(name1, name2, year)
        {
            experience = exp;
        }

        public override string ToString()
        {
            return base.ToString() + " " + experience;
        }
    }
}
