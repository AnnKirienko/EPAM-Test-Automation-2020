using System;

namespace University
{
    class Manager : Person
    {
        int roomNumber;

        public Manager (string name1, string name2, int roomN) 
        {
            firstName = name1;
            secondName = name2;
            roomNumber = roomN;
        }
    }
}
