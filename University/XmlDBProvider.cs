using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

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
        const string filesLocationPrefix = "..\\..\\Resources\\";

        public XmlDBProvider()
        {
            dbSt = LoadStudents();
            dbAd = LoadAdress();
            dbDek = LoadDekans();
            dbFc = LoadFaculties();
            dbUn = LoadUniversity();

        }

        private List<DBStudent> LoadStudents()
        {
            using (StreamReader reader = new StreamReader(filesLocationPrefix + studentsFilename, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBStudent>), new XmlRootAttribute("students"));
                return (List<DBStudent>)ser.Deserialize(reader);
            }
        }

        List<DBStudent> dbSt = new List<DBStudent>();

        private List<DBUniversity> LoadUniversity()
        {
            using (StreamReader reader = new StreamReader(filesLocationPrefix + universitiesFilename, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBUniversity>), new XmlRootAttribute("universities"));
                return (List<DBUniversity>)ser.Deserialize(reader);
            }
        }

        List<DBUniversity> dbUn = new List<DBUniversity>();

        private List<DBAdress> LoadAdress()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + adressesFilename);
            List<DBAdress> adress = new List<DBAdress>(from adr in xdoc.Element("adresses").Elements("adress")
                                                       select new DBAdress
                                                       {
                                                           CityAdr = adr.Element("cityAdr").Value,
                                                           StreetAdr = adr.Element("streetAdr").Value,
                                                           BuildingAdr = adr.Element("buildingAdr").Value,
                                                           AdressID = int.Parse(adr.Element("adressID").Value)

                                                       });
            return adress;
        }

        List<DBAdress> dbAd = new List<DBAdress>();

        private List<DBDekan> LoadDekans()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + dekansFilename);
            List<DBDekan> dekans = new List<DBDekan>(from dek in xdoc.Element("dekans").Elements("dekan")
                                                     select new DBDekan
                                                     {
                                                         FirstName = dek.Element("firstName").Value,
                                                         SecondName = dek.Element("secondName").Value,
                                                         Departament = dek.Element("faculty").Value,
                                                         YearOfBirth = int.Parse(dek.Element("yearOfBirth").Value),
                                                         Degree = dek.Element("degree").Value,
                                                         FacultyID = int.Parse(dek.Element("facultID").Value)


                                                     });
            return dekans;
        }

        List<DBDekan> dbDek = new List<DBDekan>();

        private List<DBFaculty> LoadFaculties()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + facultiesFilename);
            List<DBFaculty> faculties = new List<DBFaculty>(from facult in xdoc.Element("faculties").Elements("faculty")
                                                            select new DBFaculty
                                                            {
                                                                NameDepartament = facult.Element("name").Value,
                                                                UniversityName = facult.Element("universityName").Value,
                                                                AdressID = int.Parse(facult.Element("adressID").Value),
                                                                FacultyID = int.Parse(facult.Element("facultID").Value),
                                                                UniversityID = int.Parse(facult.Element("unID").Value)


                                                            });
            return faculties;
        }

        List<DBFaculty> dbFc = new List<DBFaculty>();

        private string GetUniversityID(string nameUniv)
        {
            return (from univ in dbUn
                    where univ.NameUniversity == nameUniv
                    select univ.UnID).First();
        }

        private string GetUniversityIDForAdress(string nameUniv)
        {
            return (from univ in dbUn
                    where univ.NameUniversity == nameUniv
                    select univ.AdressID).First();
        }

        private List<Adress> GetAdresses()
        {
            return (from DBAdress adr in dbAd
                    select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).ToList();
        }

        public Adress GetAdress(string nameUniv)
        {
           return( from DBAdress adr in dbAd
            where GetUniversityIDForAdress(nameUniv) == (adr.AdressID).ToString()            
             select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).First();
        }

        private Adress GetAdressesByID(int ID)
        {
            return (from adr in dbAd
                    where adr.AdressID == ID
                    select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).First();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>(
                from dbStudent in dbSt
                select new Student(dbStudent.FirstName, dbStudent.SecondName, int.Parse(dbStudent.YearOfBirth),
                    dbStudent.Departament, dbStudent.Marks));

            students.Sort(new StudentComparer());

            return students;
        }

        private List<Student> GetStudentsByFacultyID(string ID)
        {
            return (from dbStudent in dbSt
                    where dbStudent.FacultyID == ID
                    select new Student(dbStudent.FirstName, dbStudent.SecondName, int.Parse(dbStudent.YearOfBirth),
             dbStudent.Departament, dbStudent.Marks)).ToList();
        }

        //public void SaveStudent(Student student, string facultID)
        //{
        //    dbSt.Add(new DBStudent() {Departament=student.Departament }, facultID);
        //    using (FileStream streamer = new FileStream(filesLocationPrefix + studentsFilename, FileMode.Open))
        //    {
        //        XmlSerializer ser = new XmlSerializer(typeof(List<DBStudent>), new XmlRootAttribute("students"));
        //        ser.Serialize(streamer, dbSt);
        //    }

        //}



        public List<Dekan> GetDekans()
        {
            return (from dbDekan in dbDek
                    select new Dekan(dbDekan.FirstName, dbDekan.SecondName, dbDekan.YearOfBirth, dbDekan.Departament, 
                    dbDekan.Degree)).ToList();
        }

        public Dekan GetDekanByFacultyID(int ID)
        {


            return (from dbDekan in dbDek
                    where dbDekan.FacultyID == ID
                    select new Dekan(dbDekan.FirstName, dbDekan.SecondName, dbDekan.YearOfBirth, dbDekan.Departament,
                    dbDekan.Degree)).First();
        }

        private List<Faculty> GetFaculties()
        {

            List<Faculty> faculties = new List<Faculty>();

            foreach (DBFaculty facult in dbFc)
            {
                Faculty faculty = new Faculty(facult.NameDepartament, GetAdressesByID(facult.AdressID),
                    facult.UniversityName, GetDekanByFacultyID(facult.FacultyID));

                foreach (Student st in GetStudentsByFacultyID(facult.FacultyID.ToString()))
                {
                    faculty.AddStudent(st);
                }

                faculties.Add(faculty);
            }

            return faculties;
        }

        public List<Faculty> GetFaculties(string nameUniversity)
        {
            
            List<Faculty> faculties = new List<Faculty>();
              

            foreach (DBFaculty facult in GetFacultiesByUniversityID(int.Parse(GetUniversityID(nameUniversity))))
            {   
                Faculty faculty = new Faculty(facult.NameDepartament, GetAdressesByID(facult.AdressID),
                    facult.UniversityName, GetDekanByFacultyID(facult.FacultyID));

                foreach (Student st in GetStudentsByFacultyID(facult.FacultyID.ToString()))
                {
                    faculty.AddStudent(st);
                }

                faculties.Add(faculty);
            }

            return faculties;
        }

         public List<DBFaculty> GetFacultiesByUniversityID(int ID)
        {

            return (from fac in dbFc
                    where fac.UniversityID == ID
                    select fac).ToList();
        }

        public List<University> GetUniversities()
        {

            List<University> universities = new List<University>();

            foreach (DBUniversity univ in dbUn)
            {

                University university = new University(univ.NameUniversity, GetAdressesByID(int.Parse(univ.AdressID)));

                foreach (DBFaculty fc in GetFacultiesByUniversityID(int.Parse(univ.UnID)))
                {
                    Faculty fac = new Faculty(fc.NameDepartament, GetAdressesByID(fc.AdressID),
                        fc.UniversityName, GetDekanByFacultyID(fc.FacultyID));

                    foreach (Student st in GetStudentsByFacultyID(fc.FacultyID.ToString()))
                    {
                        fac.AddStudent(st);
                    }
                    university.AddDepartament(fac);
                }

                universities.Add(university);
            }

            return universities;
        }

        //public University GetUniversity(string nameUniv)
        //{
            
        //}

        //public List<University> GetUniversitisLinq()
        //{
        //    List<University> universities = new List<University>();

        //    return (from univ in dbUn
        //            join dbAdr in dbAd on int.Parse(univ.AdressID) equals dbAdr.AdressID
        //            let uniAdr = new Adress(dbAdr.CityAdr, dbAdr.StreetAdr, dbAdr.BuildingAdr)
        //            join fac in dbFc on int.Parse(univ.UnID) equals fac.UniversityID into uniFaculties
        //            let 
        //            join facAdr in dbAd on 

        //            select 
        //            ).ToList();

        //    return (from adr in dbAd
        //            where adr.AdressID == ID
        //            select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).First();

        //}



























    }
}
