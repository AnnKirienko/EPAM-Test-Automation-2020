using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
   public class Institute : Departament
    {
       Manager manager;

       public Institute (string name, Adress adr, Manager man ) : base(name, adr)
       {
            manager = man;
       }

       public override string ToString()
       {
           return base.ToString() + " " + manager;
       }
    }
}
