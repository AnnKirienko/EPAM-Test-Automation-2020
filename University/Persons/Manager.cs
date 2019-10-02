using System;

namespace University
{
   public class Manager : Person
    {
        int roomNumber;

        public Manager (string name1, string name2, int year, int roomN) : base(name1, name2, year)
        {
            roomNumber = roomN;
        }

        public override string ToString()
        {
            return base.ToString() + " " + roomNumber;
        }
    }
}
