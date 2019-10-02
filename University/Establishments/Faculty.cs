using System;

namespace University 
{
    public class Faculty : Departament
    {
        Dekan dekan;
        Student [] arrayStudents = new Student[2];

        public Faculty(string name, Adress adr, Dekan dek) : base(name, adr) 
      
        {
          dekan = dek;
        }

        

        public override string ToString()
        {
            string studentStr = "";
            foreach (Student student in arrayStudents)
                studentStr += (" " + student);

            return base.ToString() + " " + dekan + " " + studentStr;
        }

        int count = 0;

        bool CanBeAdded(Student student)
        {

            for (int i = 0; i < arrayStudents.Length; i++)
            {
                Student element = arrayStudents[i];

                if (element != null && element.Equals(student))
                {
                    return false;
                }
            }
            return true;
        }

        public bool AddStudent(Student student)
        {
            if ((count < 2) && this.CanBeAdded(student))
            {
                arrayStudents[count] = student;
                count++;
                Console.WriteLine("Adding " + student);
                return true;
            }
            return false;

        }



    }
}
