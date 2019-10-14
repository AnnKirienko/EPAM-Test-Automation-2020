using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
   public class XmlDBProvider : IDBProvider
    {
            private XmlReader reader = new XmlReader();

            const string adressesFilename = "Adress.xml";
            const string accountantsFilename = "Accountants.xml";
            const string autocadesFilename = "Autocades.xml";
            const string carsFilename = "Car.xml";
            const string dekansFilename = "Dekans.xml";
            const string employeesFilename = "Employees.xml";
            const string facultiesFilename = "Faculties.xml";
            const string garagesFilename = "Garages.xml";
            const string headsFilename = "Heads.xml";
            const string institutesFilename = "Institutes.xml";
            const string managersFilename = "Managers.xml";
            const string staffesFilename = "Staffes.xml";
            const string studentsFilename = "Students.xml";
            const string universitiesFilename = "Universities.xml";
           
            private List<Dictionary<string, string>> ReadFromXml (string fileName, string nodeName, List<string> fieldsToLookFor)
            {         
                return reader.Load(fileName, nodeName, fieldsToLookFor);
            }

           public List<Adress> GetAdresses()
            {
               List<Dictionary<string, string>> parsedAdresses = ReadFromXml(adressesFilename, "adress", new List<string> { "cityAdr", "streetAdr", "buildingAdr" });
               List<Adress> adresses = new List<Adress>();

               foreach (Dictionary<string, string> adressValues in parsedAdresses)
               {
                   adresses.Add(new Adress(adressValues["cityAdr"], adressValues["streetAdr"], adressValues["buildingAdr"]));
               }

             return adresses;
            }

           public Adress GetAdressesByID(string ID)
            {
                List<Dictionary<string, string>> parsedAdresses = ReadFromXml(adressesFilename, "adress", new List<string> { "cityAdr", "streetAdr", "buildingAdr", "adressID" });
               
                foreach (Dictionary<string, string> adressValues in parsedAdresses)
                {
                    if (ID.Equals(adressValues["adressID"]))
                    {
                    return new Adress(adressValues["cityAdr"], adressValues["streetAdr"], adressValues["buildingAdr"]);
                    }
                 }
                return null;
            }

           public List<Student> GetStudents()
            {
                List<Dictionary<string, string>> parsedStudents = ReadFromXml(studentsFilename, "student", new List<string> { "firstName", "secondName", "yearOfBirth", "marks", "faculty" });
                List<Student> students = new List<Student>();
                
                foreach (Dictionary<string, string> studentValues in parsedStudents)
                {
                    students.Add(new Student(studentValues["firstName"], studentValues["secondName"], int.Parse(studentValues["yearOfBirth"]), studentValues["faculty"],Array.ConvertAll(studentValues["marks"].Split(' '), int.Parse).ToList() ));
                }

                return students;
            }

           public List<Student> GetStudentsByID(string ID)
            {
                List<Dictionary<string, string>> parsedStudents = ReadFromXml(studentsFilename, "student", new List<string> { "firstName", "secondName", "yearOfBirth", "marks", 
                    "faculty", "facultID" });
                List<Student> students = new List<Student>();

                foreach (Dictionary<string, string> studentValues in parsedStudents)
                {
                    if (ID.Equals(studentValues["facultID"]))
                    students.Add(new Student(studentValues["firstName"], studentValues["secondName"], int.Parse(studentValues["yearOfBirth"]),
                        studentValues["faculty"], Array.ConvertAll(studentValues["marks"].Split(' '), int.Parse).ToList()));
                }

                return students;
            }

          

           public List<Dekan> GetDekans()
            {
                List<Dictionary<string, string>> parsedDekans = ReadFromXml(dekansFilename, "dekan", new List<string> { "firstName", "secondName", "yearOfBirth", "degree", "faculty" });
                List<Dekan> dekans = new List<Dekan>();

                foreach (Dictionary<string, string> dekanValues in parsedDekans)
                {
                    dekans.Add(new Dekan(dekanValues["firstName"], dekanValues["secondName"], int.Parse(dekanValues["yearOfBirth"]), dekanValues["faculty"], dekanValues["degree"] ));
                }

                return dekans;
            }

           public Dekan GetDekanByID(string ID)
            {
                List<Dictionary<string, string>> parsedDekans = ReadFromXml(dekansFilename, "dekan", new List<string> { "firstName", "secondName", "yearOfBirth", "degree", "faculty", "facultID" });
               
                foreach (Dictionary<string, string> dekanValues in parsedDekans)
                {
                    if (ID.Equals(dekanValues["facultID"]))
                    return new Dekan(dekanValues["firstName"], dekanValues["secondName"], int.Parse(dekanValues["yearOfBirth"]), dekanValues["faculty"], dekanValues["degree"]);
                }

                return null;
            }

           public List<Faculty> GetFaculties()
            {
                List<Dictionary<string, string>> parsedFaculties = ReadFromXml(facultiesFilename, "faculty", new List<string> { "name", "universityName", "adressID" , "facultID"});
                List<Faculty> faculties = new List<Faculty>();
                foreach (Dictionary<string, string> facultyValues in parsedFaculties)
                {
                    
                    Adress adr = this.GetAdressesByID(facultyValues["adressID"]);
                    List<Student> stud = this.GetStudentsByID(facultyValues["facultID"]);
                    Dekan dek = this.GetDekanByID(facultyValues["facultID"]);
                   Faculty faculty =  new Faculty(facultyValues["name"], adr, facultyValues["universityName"], dek);
                    foreach (Student st in stud)
                    { 
                        faculty.AddStudent(st);
                    }
                    faculties.Add(faculty);
                }

                return faculties;
            }

           public List<Garage> GetGarages()
           {
               List<Dictionary<string, string>> parsedGarages = ReadFromXml(garagesFilename, "garage", new List<string> { "square", "number", "adressID" });
               List<Garage> garages = new List<Garage>();

               foreach (Dictionary<string, string> garageValues in parsedGarages)
               {
                   Adress adr = this.GetAdressesByID(garageValues["adressID"]);
                   garages.Add(new Garage(adr, float.Parse(garageValues["square"]), int.Parse(garageValues["number"])));
               }

               return garages;
           }

           public List<Car> GetCars()
           {
               List<Dictionary<string, string>> parsedCars = ReadFromXml(carsFilename, "car", new List<string> { "name", "year", "fuel" });
               List<Car> cars = new List<Car>();

               foreach (Dictionary<string, string> carValues in parsedCars)
               {
                   cars.Add(new Car(carValues["name"], int.Parse(carValues["year"]), carValues["fuel"]));
               }

               return cars;
           }

           //public List<Head> GetHeads()
           //{
           //    List<Dictionary<string, string>> parsedHeads = ReadFromXml(headsFilename, "head", new List<string> { "firstName", "secondName", "yearOfBirth", "degree", "faculty" });
           //    List<Head> heads = new List<Head>();

           //    foreach (Dictionary<string, string> headValues in parsedHeads)
           //    {
           //        heads.Add(new Head(headValues["firstName"], headValues["secondName"], int.Parse(headValues["yearOfBirth"]), headValues["faculty"], headValues["degree"]));
           //    }

           //    return heads;
           //}

           //public Dekan GetDekanByID(string ID)
           //{
           //    List<Dictionary<string, string>> parsedDekans = ReadFromXml(dekansFilename, "dekan", new List<string> { "firstName", "secondName", "yearOfBirth", "degree", "faculty", "facultID" });

           //    foreach (Dictionary<string, string> dekanValues in parsedDekans)
           //    {
           //        if (ID.Equals(dekanValues["facultID"]))
           //            return new Dekan(dekanValues["firstName"], dekanValues["secondName"], int.Parse(dekanValues["yearOfBirth"]), dekanValues["faculty"], dekanValues["degree"]);
           //    }

           //    return null;
           //}























    }
}
