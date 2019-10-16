using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
   public class ObjectConverter
    {
       public Student Convert(DBStudent dbStudent)
       {            
         return new Student(dbStudent.FirstName, dbStudent.SecondName, int.Parse(dbStudent.YearOfBirth),
               dbStudent.Departament, Array.ConvertAll(dbStudent.Marks.Split(' '), int.Parse).ToList());
       }

        public DBStudent Convert(Student student, string facultID)
        {
            return new DBStudent
            {
                FirstName = student.FirstName,
                SecondName = student.SecondName,
                YearOfBirth = student.YearOfBirth.ToString(),
                Departament = student.Departament,
                Marks = student.Marks,
                FacultyID = facultID
            };
        }

        public Adress Convert(DBAdress dbAdress)
       {
           return new Adress(dbAdress.CityAdr, dbAdress.StreetAdr, dbAdress.BuildingAdr);
       }

       public Dekan Convert(DBDekan dbDekan)
       {
           return new Dekan(dbDekan.FirstName, dbDekan.SecondName, dbDekan.YearOfBirth, dbDekan.Departament, dbDekan.Degree);
       }

    }
}
