using System;

namespace University
{
    public class Staff : Departament
    {
        Head head;
        
        public Staff (string name, Adress adr, Head hed ) : base(name, adr)
       {
            head = hed;
       }

        public override string ToString()
        {
            return base.ToString() + " " + head;
        }
    }
}
