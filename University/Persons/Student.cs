using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using Newtonsoft.Json;

namespace University
{

    public class Student : Person, IComparable
    {


        List<int> marks;


        public string Marks { get { return String.Join(" ", marks.ToArray()); } set { marks = Array.ConvertAll(value.Split(' '), int.Parse).ToList(); } }

        public Student(string name1, string name2, int year, string departament, List<int> marks)
            : base(name1, name2, departament, year)
        {

            this.marks = marks;
        }

        public Student(string name1, string name2, int year, string departament, string marks)
          : this(name1, name2, year, departament, Array.ConvertAll(marks.Split(' '), int.Parse).ToList())
        {
        }
        public Student()
        { }


        public override string ToString()
        {
            return base.ToString() + " " + string.Join(", ", marks);
        }

        public float GetAverageScore(List<int> marks)
        {
            float score = ((marks.Sum()) / (marks.Count));
            return score;
        }

        public int CompareTo(object obj)
        {
            Student stud = obj as Student;
            if (stud != null)
                return this.Marks.CompareTo(stud.Marks);
            else
                throw new Exception("Невозможно сравнить два объекта");
            //throw new NotImplementedException();
        }
    }
}
