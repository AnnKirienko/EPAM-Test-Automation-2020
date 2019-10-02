using System;



namespace University
{
   public class Student : Person
    {
        int[] marks;

        public Student(string name1, string name2, int year, int[] marks) : base(name1, name2, year)
        {
            this.marks = marks;
        }

        public override string ToString()
        {
            return base.ToString() + " " + string.Join(", ", marks); 
        }

      
    }
}
