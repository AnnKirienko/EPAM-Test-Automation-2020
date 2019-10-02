using System;

namespace University
{
   public class Departament
    {
       string nameDepartament;
       Adress adress;

       public Departament()
       {
       }

       public Departament(string nameDepartament, Adress adress)
       {
           this.adress =  adress;
           this.nameDepartament = nameDepartament;

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
