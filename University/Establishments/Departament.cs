using System;

namespace University
{
   public class Departament
    {
       string nameDepartament;
       Adress adress;
       string universityName;

       public Departament()
       {
       }

       public Departament(string nameDepartament, Adress adress, string universityName)
       {
           this.adress =  adress;
           this.nameDepartament = nameDepartament;
           this.universityName = universityName;;

       }

       public override bool Equals(object obj)
       {
           return (nameDepartament == (obj as Departament).nameDepartament) && adress.Equals((obj as Departament).adress);           
       }

       public override string ToString()
       {
           return nameDepartament + " " + adress;
       }

    }
}
