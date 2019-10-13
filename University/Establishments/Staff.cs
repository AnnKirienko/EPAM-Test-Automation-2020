using System;
using System.Collections.Generic;

namespace University
{
    public class Staff : Departament
    {
        Head head;
        //Accountant[] arrayAccounants = new Accountant[2];
        List<Accountant> listAccountant = new List<Accountant>();
        public Staff (string name, Adress adr, string universityName, Head hed ) : base(name, adr, universityName)
       {
            head = hed;
       }

        public override string ToString()
        {
            string accountantStr = "";
            foreach (Accountant accountant in listAccountant)
                accountantStr += (" " + accountant);

            return base.ToString() + " " + head + " " + accountantStr;
        }

        bool CanBeAdded(Accountant accountant)
        {
            foreach (Accountant acc in listAccountant)
              {
                if (acc != null && acc.Equals(accountant))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddAccountant(Accountant accountant)
        {
            if ((listAccountant.Count < 2) && this.CanBeAdded(accountant))
            {
                listAccountant.Add(accountant);
                Console.WriteLine("Adding " + accountant);
                return true;
            }
            return false;

        }
    }
}
