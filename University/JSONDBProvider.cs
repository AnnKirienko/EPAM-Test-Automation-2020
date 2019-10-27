using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;



namespace University
{
    public class JSONDBProvider : IDBProvider
    {
        const string studentsFilename = "Students.json";
        const string universitiesFilename = "Universities.json";
        const string filesLocationPrefix = "..\\..\\Resources\\JSON\\";

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public JSONDBProvider()
        { }

        public void SaveUniversitiesToJSONFile(List<University> universities)
        {
            File.WriteAllText(filesLocationPrefix + universitiesFilename, JsonConvert.SerializeObject(universities, settings));
        }

        public List<University> GetUniversitiesFromJSONFile()
          {
            using(StreamReader reader = new StreamReader(filesLocationPrefix + universitiesFilename, Encoding.UTF8))
            {
             return new List<University>(JsonConvert.DeserializeObject<IEnumerable<University>>(reader.ReadToEnd(), settings));
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

        public List<Faculty> GetFaculties(string nameUniv)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            //List<Student> students = new List<Student>();
            //foreach (DBStudent stud in dbSt)
            //{
            //    students.Add(converter.Convert(stud));
            //}
            //students.Sort(new StudentComparer());

            return null;
            
        }

       

        public List<University> GetUniversities()
        {
            throw new NotImplementedException();
        }

        public Adress GetAdress(string nameUniversity)
        {
            throw new NotImplementedException();
        }
    }
}
