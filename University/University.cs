using System;

namespace University
{
   public class University
    {
       string nameUniversity;
       Adress adressUniversity; 
       Departament[] arrayDepartaments  = new Departament [10];

      public  University(string name, Adress adr)
      {
           nameUniversity = name;
           adressUniversity = adr;
       }

       int count = 0;

       bool CanBeAdded(Departament departament)
       {
         
           for (int i = 0; i < arrayDepartaments.Length; i++)
           {
               Departament element = arrayDepartaments[i];

               if (element!= null && element.Equals(departament))
               {
                   return false;
               }
           }
           return true;
       }

       public bool AddDepartament(Departament departament )
       {
           if ((count < 10) && this.CanBeAdded(departament))
           {
               arrayDepartaments[count] = departament;
               count++;
               Console.WriteLine ("Adding " + departament); 
               return true;
           }
               return false;          
           
       }

       public override string ToString()
       {
           string departamentStr = "";
           foreach (Departament departament in arrayDepartaments)
               departamentStr += (" " + departament);

           return nameUniversity + " " + adressUniversity + " " + departamentStr;
       }

    }
}
