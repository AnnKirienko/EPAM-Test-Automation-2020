using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace University
{
    
   public class Student : Person
    {
        List<int> marks;   
        public Student(string name1, string name2, int year, string departament, List<int> marks): base(name1, name2, departament, year)
        {
           
            this.marks = marks;
        }

        public Student()
        { }

        public override string ToString()
        {
            return base.ToString() + " " + string.Join(", ", marks) ; 
        }

        
       

      
    }
}
