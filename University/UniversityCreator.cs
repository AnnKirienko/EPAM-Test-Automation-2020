using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    public class UniversityCreator
    {
        IDBProvider prov = new XmlDBProvider();

        public University CreateUniversity(string nameUniversity)
        {
            University university = new University(nameUniversity, prov.GetAdress(nameUniversity), prov.GetRector(nameUniversity));

            prov.GetFaculties(nameUniversity).ForEach(fac => university.AddDepartament(fac));

            return university;
        }

        public void SaveUniversity(University university)
        {
            prov.SaveUniversity(university);
        }

    }
}