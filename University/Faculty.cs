using System;

namespace University 
{
    public class Faculty : Departament
    {
        Dekan dekan;

        public Faculty (string name, Adress adr, Dekan dek ) : base()
       {
            nameDepartaments = name;
            adress = adr;
            dekan = dek;
       }

    }
}
