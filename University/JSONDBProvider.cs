using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;



namespace University
{
    public class JSONDBProvider: IDBProvider
    {
        const string studentsFilename = "Students.json";
       // const string universitiesFilename = "Universities.xml";
        const string filesLocationPrefix = "..\\..\\Resources\\JSON\\";

        private ObjectConverter converter = new ObjectConverter();

        public JSONDBProvider()
        { dbSt = LoadStudents(); }

        private List<DBStudent> LoadStudents()
        {
            using (StreamReader reader = new StreamReader(filesLocationPrefix + studentsFilename, Encoding.Unicode))
            {
            //    DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

            //    DataTable dataTable = dataSet.Tables["student"];

            //    Console.WriteLine(dataTable.Rows.Count);
            //    // 2

                //foreach (DataRow row in dataTable.Rows)
                //{
                //    Console.WriteLine(row["id"] + " - " + row["item"]);
                //}
                //// 0 - item 0
                //// 1 - item 1

                return new List <DBStudent> (JsonConvert.DeserializeObject<IEnumerable<DBStudent>>(reader.ReadToEnd()));
                
                //return JsonConvert.DeserializeObject<>();
                //return JsonConvert.DeserializeObject<List<DBStudent>>(reader.ReadToEnd());
            }
        }

        List<DBStudent> dbSt = new List<DBStudent>();

        public List<Adress> GetAdresses()
        {
            throw new NotImplementedException();
        }

        public List<Dekan> GetDekans()
        {
            throw new NotImplementedException();
        }

        public List<Faculty> GetFaculties()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            foreach (DBStudent stud in dbSt)
            {
                students.Add(converter.Convert(stud));
            }
            students.Sort(new StudentComparer());

            return students;
            
        }

        public void SaveStudent(Student student, string facultID)
        {
            throw new NotImplementedException();
        }

        public List<University> GetUniversities()
        {
            throw new NotImplementedException();
        }
    }
}
