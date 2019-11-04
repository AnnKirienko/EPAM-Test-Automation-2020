using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace University
{
    public class University
    {
        string nameUniversity;
        Adress adressUniversity;
        Rector rector;
        List<Departament> listDepartament = new List<Departament>();

        public string NameUniversity { get => nameUniversity; set => nameUniversity = value; }
        public Adress AdressUniversity { get => adressUniversity; set => adressUniversity = value; }
        public List<Departament> ListDepartament { get => listDepartament; set => listDepartament = value; }
        public Rector Rector { get => rector; set => rector = value; }

        public University(string name, Adress adr, Rector rect)
        {
            nameUniversity = name;
            adressUniversity = adr;
            rector = rect;
        }
        public University()
        { }

        public University(string name, Adress adr, List<Departament> listDep, Rector rect)
        {
            nameUniversity = name;
            adressUniversity = adr;
            listDepartament = listDep;
            rector = rect;
        }


        public List<Departament> GetDepartments() { return ListDepartament; }


        public void PrintMessage(string mes)
        { Console.WriteLine("Student was added!!!!!!!!!!!!!!!!!!"); }



        bool CanBeAdded(Departament departament)
        {

            foreach (Departament dptr in ListDepartament)
            {
                if (dptr != null && dptr.Equals(departament))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddDepartament(Departament departament)
        {
            if ((ListDepartament.Count < 10) && this.CanBeAdded(departament))
            {
                if (departament is Faculty)
                {
                    (departament as Faculty).Notification += this.PrintMessage;
                }
                ListDepartament.Add(departament);
                Console.WriteLine("Adding " + departament);
                return true;
            }
            return false;

        }


        public override string ToString()
        {
            string departamentStr = "";
            foreach (Departament departament in ListDepartament)
                departamentStr += (" " + departament);

            return NameUniversity + " " + AdressUniversity + " " + Rector + " " + departamentStr;
        }

    }
}
