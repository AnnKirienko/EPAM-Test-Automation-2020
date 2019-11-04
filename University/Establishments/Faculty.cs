using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace University 
{
    public class Faculty : Departament
    {
        Dekan dekan;
        List<Student> listStudents  = new List<Student> ();

        public Dekan Dekan { get => dekan; set => dekan = value; }
        public List<Student> ListStudents { get => listStudents; set => listStudents = value; }

        public delegate void StudAdded(string message);
        public event StudAdded Notification;

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
                
                Notification?.Invoke("Student was added");
                Console.WriteLine("Adding " + student);
                return true;
            }
            return false;

        }

    }
}
