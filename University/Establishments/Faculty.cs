using System;
using System.Collections.Generic;


namespace University 
{
    public class Faculty : Departament
    {
        Dekan dekan;
        //Student [] arrayStudents = new Student[2];
        List<Student> listStudents  = new List<Student> ();

        public Faculty(string name, Adress adr, string universityName, Dekan dek) : base(name, adr,universityName) 
      
        {
          dekan = dek;
        }

        public Faculty()
        { }

        

        public override string ToString()
        {
            string studentStr = "";
            foreach (Student student in listStudents)
                studentStr += (" " + student);

            return base.ToString() + " " + dekan + " " + studentStr;
        }

        

        bool CanBeAdded(Student student)
        {
            foreach (Student stud in listStudents)
            
            {
                if (stud != null && stud.Equals(student))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddStudent(Student student)
        {
            if ((listStudents.Count < 2) && this.CanBeAdded(student))
            {
                listStudents.Add(student);
                Console.WriteLine("Adding " + student);
                return true;
            }
            return false;

        }



    }
}
