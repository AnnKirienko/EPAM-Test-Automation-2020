using System;

namespace University
{
   public class Manager : Person
    {
        int roomNumber;

        public Manager (string name1, string name2, string departament, int year, int roomN) : base(name1, name2, departament, year)
        {
            roomNumber = roomN;
        }

        public override string ToString()
        {
            return base.ToString() + " " + roomNumber;
        }
    }
}
