using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student st1, Student st2)
        {
            if (st1.SecondName != null && st2.SecondName != null)
            {
                return st1.SecondName.CompareTo(st2.SecondName);
            }
            else
                
               throw new NotImplementedException();
            
        }
    }
}
