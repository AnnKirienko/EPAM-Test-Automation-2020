using System;
using System.Collections.Generic;

namespace University
{
   public class University
    {
       string nameUniversity;
       Adress adressUniversity; 
       //Departament[] arrayDepartaments  = new Departament [10];
       List<Departament> listDepartament = new List<Departament>();

      public  University(string name, Adress adr)
      {
           nameUniversity = name;
           adressUniversity = adr;
       }

      

       bool CanBeAdded(Departament departament)
       {

           foreach (Departament dptr in listDepartament)
           {
               if (dptr != null && dptr.Equals(departament))
               {
                   return false;
               }
           }
           return true;
       }

       public bool AddDepartament(Departament departament )
       {
           if ((listDepartament.Count < 10) && this.CanBeAdded(departament))
           {
               listDepartament.Add(departament);
               Console.WriteLine ("Adding " + departament); 
               return true;
           }
               return false;          
           
       }

      
        public override string ToString()
       {
           string departamentStr = "";
           foreach (Departament departament in listDepartament)
               departamentStr += (" " + departament);

           return nameUniversity + " " + adressUniversity + " " + departamentStr;
       }

    }
}
