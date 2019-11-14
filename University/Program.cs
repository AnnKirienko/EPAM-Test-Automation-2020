using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityCreator creator = new UniversityCreator();
            JSONDBProvider jsprovider = new JSONDBProvider();

            University univer = creator.CreateUniversity("BSU");
            Console.WriteLine(univer);
            Console.WriteLine("\n________________________________________");

            jsprovider.SaveUniversitiesToJSONFile(new List<University> { univer });
            foreach (University univ in jsprovider.GetUniversitiesFromJSONFile())
            {
                Console.WriteLine(univ);
            }

            creator.SaveUniversity(univer);
            Console.WriteLine("#####");
            Console.WriteLine(creator.CreateUniversity("BSU"));

            //foreach (University univ in creator.GetUniversities())
            //{
            //    var dpts = univ.GetDepartments();
            //    foreach (var dpt in dpts)
            //    {
            //        if (dpt is Faculty)
            //        {
            //            (dpt as Faculty).AddStudent(new Student("aaaaaaaaaaaa", "bbbb", 354, "zxcvbnm", new List<int>()));
            //        }
            //    }

            //}

            //jsprovider.GetStudents();

            //foreach (Student stud in jsprovider.GetStudents())
            //   Console.WriteLine(stud);

            // Console.WriteLine(new StreamReader("..\\..\\Resources\\Students.xml", Encoding.UTF8).ReadToEnd());
            //provider.SaveStudent(new Student("tgrfw", "tegtgwfgh", 852, "qwertyuiop", new List<int>()),"1");
            //foreach (Faculty facult in provider.GetFaculties())
            // Console.WriteLine(facult);

        }
    }
}