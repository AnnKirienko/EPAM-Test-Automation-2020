using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    public class UniversityCreator
    {
        IDBProvider prov = new XmlDBProvider();

        //public List <University> GetUniversities()
        //{

        //    return prov.GetUniversities();
        //}

        public University CreateUniversity(string nameUniversity)
        {
            University university = new University(nameUniversity, prov.GetAdress(nameUniversity));
            foreach (Faculty faculty in prov.GetFaculties(nameUniversity))
                university.AddDepartament(faculty);

            return university;
        }

        public void SaveUniversity(University university)
        {

        }

    }
}
