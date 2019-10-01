using System;

namespace University
{
    class Staff : Departament
    {
        Head head;
        
        public Staff (string name, Adress adr, Head hed ) : base()
       {
            nameDepartaments = name;
            adress = adr;
            head = hed;
       }
    }
}
