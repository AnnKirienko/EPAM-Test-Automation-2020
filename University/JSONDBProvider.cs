using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

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

        public JSONDBProvider() { }

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

        public Rector GetRector(string nameUniversity)
        {
            throw new NotImplementedException();
        }

        public List<Faculty> GetFaculties(string nameUniv)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
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

        public void SaveStudent(Student student, string facultID)
        {
            throw new NotImplementedException();
        }

        public void SaveUniversity(University university)
        {
            throw new NotImplementedException();
        }
    }
}