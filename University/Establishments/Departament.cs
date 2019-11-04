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
           this.universityName = universityName;
       }

        public string NameDepartament { get => nameDepartament; set => nameDepartament = value; }
        public Adress Adress { get => adress; set => adress = value; }
        public string UniversityName { get => universityName; set => universityName = value; }

        public override bool Equals(object obj)
       {
            if ((obj == null)||!this.GetType().Equals(obj.GetType())) {
                return false;
            }

            return (nameDepartament == (obj as Departament).nameDepartament) && adress.Equals((obj as Departament).adress);           
       }

       public override string ToString()
       {
           return nameDepartament + " " + adress;
       }

    }
}
