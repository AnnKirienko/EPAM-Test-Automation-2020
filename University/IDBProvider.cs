using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    interface IDBProvider
    {
        Adress GetAdress(string nameUniversity);

        List<Faculty> GetFaculties(string nameUniversity);

        List<Dekan> GetDekans();

        Rector GetRector(string nameUniversity);

        List<Student> GetStudents();

        List<University> GetUniversities();

        void SaveUniversity(University university);
    }
}