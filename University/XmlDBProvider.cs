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
        const string rectorsFilename = "Rectors.xml";
        const string filesLocationPrefix = "..\\..\\Resources\\";

        private Dictionary<Type, int> dbObjectToCurrentId = new Dictionary<Type, int>();

        List<DBStudent> dbSt = new List<DBStudent>();
        List<DBDekan> dbDek = new List<DBDekan>();
        List<DBRector> dbRec = new List<DBRector>();
        List<DBAdress> dbAd = new List<DBAdress>();
        List<DBUniversity> dbUn = new List<DBUniversity>();
        List<DBFaculty> dbFc = new List<DBFaculty>();

        public XmlDBProvider()
        {
            dbSt = LoadStudents();
            dbAd = LoadAdress();
            dbDek = LoadDekans();
            dbFc = LoadFaculties();
            dbUn = LoadUniversity();
            dbRec = LoadRectors();
        }

        private void resetCacheLists()
        {
            dbSt = new List<DBStudent>();
            dbAd = new List<DBAdress>();
            dbDek = new List<DBDekan>();
            dbFc = new List<DBFaculty>();
            dbUn = new List<DBUniversity>();
            dbRec = new List<DBRector>();
        }

        private List<DBStudent> LoadStudents()
        {
            using(StreamReader reader = new StreamReader(filesLocationPrefix + studentsFilename, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBStudent>), new XmlRootAttribute("students"));
                return (List<DBStudent>) ser.Deserialize(reader);
            }
        }

        private List<DBUniversity> LoadUniversity()
        {
            using(StreamReader reader = new StreamReader(filesLocationPrefix + universitiesFilename, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBUniversity>), new XmlRootAttribute("universities"));
                return (List<DBUniversity>) ser.Deserialize(reader);
            }
        }

        private List<DBAdress> LoadAdress()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + adressesFilename);
            List<DBAdress> adress = new List<DBAdress>(from adr in xdoc.Element("adresses").Elements("adress") select new DBAdress
            {
                CityAdr = adr.Element("cityAdr").Value,
                    StreetAdr = adr.Element("streetAdr").Value,
                    BuildingAdr = adr.Element("buildingAdr").Value,
                    AdressID = int.Parse(adr.Element("adressID").Value)

            });
            return adress;
        }

        private List<DBDekan> LoadDekans()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + dekansFilename);
            List<DBDekan> dekans = new List<DBDekan>(from dek in xdoc.Element("dekans").Elements("dekan") select new DBDekan
            {
                FirstName = dek.Element("firstName").Value,
                    SecondName = dek.Element("secondName").Value,
                    Departament = dek.Element("departament").Value,
                    YearOfBirth = int.Parse(dek.Element("yearOfBirth").Value),
                    Degree = dek.Element("degree").Value,
                    FacultyID = int.Parse(dek.Element("facultyID").Value)

            });
            return dekans;
        }

        private List<DBRector> LoadRectors()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + rectorsFilename);
            List<DBRector> rectors = new List<DBRector>(from rec in xdoc.Element("rectors").Elements("rector") select new DBRector
            {
                FirstName = rec.Element("firstName").Value,
                    SecondName = rec.Element("secondName").Value,
                    Departament = rec.Element("university").Value,
                    YearOfBirth = int.Parse(rec.Element("yearOfBirth").Value),
                    UnID = int.Parse(rec.Element("unID").Value)
            });

            return rectors;
        }

        private List<DBFaculty> LoadFaculties()
        {
            XDocument xdoc = XDocument.Load(filesLocationPrefix + facultiesFilename);
            List<DBFaculty> faculties = new List<DBFaculty>(from facult in xdoc.Element("faculties").Elements("faculty") select new DBFaculty
            {
                NameDepartament = facult.Element("name").Value,
                    UniversityName = facult.Element("universityName").Value,
                    AdressID = int.Parse(facult.Element("adressID").Value),
                    FacultyID = int.Parse(facult.Element("facultID").Value),
                    UniversityID = int.Parse(facult.Element("unID").Value)

            });
            return faculties;
        }

        private int getNextId(Type type)
        {
            int maxId = dbObjectToCurrentId.TryGetValue(type, out var value) ? value : 0; 
            maxId++;
            dbObjectToCurrentId[type] = maxId;

            return maxId;
        }

        public void SaveUniversity(University university)
        {
            this.resetCacheLists();

            string name = university.NameUniversity;

            int adressId = this.SaveAdress(university.AdressUniversity);

            int universityId = getNextId(typeof(University));

            this.SaveRector(university.Rector, universityId);

            foreach (Departament dep in university.ListDepartament)
            {
                if (dep is Faculty)
                {
                    this.SaveFaculty(dep as Faculty, universityId);
                }
            }

            dbUn.Add(new DBUniversity
            {
                NameUniversity = university.NameUniversity, AdressID = adressId.ToString(), UnID = universityId.ToString()
            });

            using(StreamWriter writer = new StreamWriter(filesLocationPrefix + universitiesFilename, false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBUniversity>), new XmlRootAttribute("universities"));
                ser.Serialize(writer, dbUn);
            }
        }

        public void SaveRector(Rector rector, int universityId)
        {
            dbRec.Add(new DBRector
            {
                FirstName = rector.FirstName,
                    SecondName = rector.SecondName,
                    Departament = rector.Departament,
                    YearOfBirth = rector.YearOfBirth,
                    UnID = universityId
            });

            using(StreamWriter writer = new StreamWriter(filesLocationPrefix + rectorsFilename, false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBRector>), new XmlRootAttribute("rectors"));
                ser.Serialize(writer, dbRec);
            }
        }

        private int SaveAdress(Adress adress)
        {
            DBAdress existingAdr = dbAd.FirstOrDefault(ad =>
            {
                return ad.BuildingAdr.Equals(adress.BuildingAdr) &&
                    ad.CityAdr.Equals(adress.CityAdr) &&
                    ad.StreetAdr.Equals(adress.StreetAdr);
            }) ;

            if (existingAdr != null)
            {
                return existingAdr.AdressID;
            }

            int adressId = getNextId(typeof(Adress));

            dbAd.Add(new DBAdress
            {
                CityAdr = adress.CityAdr, StreetAdr = adress.StreetAdr, BuildingAdr = adress.BuildingAdr, AdressID = adressId
            });

            using(StreamWriter writer = new StreamWriter(filesLocationPrefix + adressesFilename, false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBAdress>), new XmlRootAttribute("adresses"));
                ser.Serialize(writer, dbAd);
            }

            return adressId;
        }

        private int SaveFaculty(Faculty faculty, int universityID)
        {
            int facultyId = getNextId(typeof(Faculty));

            this.SaveDekan(faculty.Dekan, facultyId);

            faculty.ListStudents.ForEach(stud => this.SaveStudent(stud, facultyId));

            int adressId = this.SaveAdress(faculty.Adress);

            dbFc.Add(new DBFaculty
            {
                AdressID = adressId, FacultyID = facultyId, NameDepartament = faculty.NameDepartament, UniversityID = universityID,
                UniversityName = faculty.UniversityName
            });

            using(StreamWriter writer = new StreamWriter(filesLocationPrefix + facultiesFilename, false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBFaculty>), new XmlRootAttribute("faculties"));
                ser.Serialize(writer, dbFc);
            }

            return facultyId;
        }

        private void SaveStudent(Student student, int facultID)
        {
            DBStudent dbStudent = new DBStudent()
            {
                FirstName = student.FirstName, SecondName = student.SecondName,
                Departament = student.Departament, FacultyID = facultID.ToString(),
                Marks = student.Marks, YearOfBirth = student.YearOfBirth.ToString()
            };

            dbSt.Add(dbStudent);

            using(StreamWriter writer = new StreamWriter(filesLocationPrefix + studentsFilename, false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBStudent>), new XmlRootAttribute("students"));
                ser.Serialize(writer, dbSt);
            }
        }

        public void SaveDekan(Dekan dekan, int facultyID)
        {
            dbDek.Add(new DBDekan
            {
                FirstName = dekan.FirstName, SecondName = dekan.SecondName,
                    Degree = dekan.Degree, Departament = dekan.Departament,
                    FacultyID = facultyID, YearOfBirth = dekan.YearOfBirth
            });

            using(StreamWriter writer = new StreamWriter(filesLocationPrefix + dekansFilename, false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DBDekan>), new XmlRootAttribute("dekans"));
                ser.Serialize(writer, dbDek);
            }
        }

        private string GetUniversityID(string nameUniv)
        {
            return (from univ in dbUn where univ.NameUniversity == nameUniv select univ.UnID).First();
        }

        private string GetUniversityIDForAdress(string nameUniv)
        {
            return (from univ in dbUn where univ.NameUniversity == nameUniv select univ.AdressID).First();
        }

        private List<Adress> GetAdresses()
        {
            return (from DBAdress adr in dbAd select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).ToList();
        }

        public Adress GetAdress(string nameUniv)
        {
            return (from DBAdress adr in dbAd where GetUniversityIDForAdress(nameUniv) == (adr.AdressID).ToString() select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).First();
        }

        private Adress GetAdressesByID(int ID)
        {
            return (from adr in dbAd where adr.AdressID == ID select new Adress(adr.CityAdr, adr.StreetAdr, adr.BuildingAdr)).First();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>(
                from dbStudent in dbSt select new Student(dbStudent.FirstName, dbStudent.SecondName, int.Parse(dbStudent.YearOfBirth),
                    dbStudent.Departament, dbStudent.Marks));

            students.Sort(new StudentComparer());

            return students;
        }

        private List<Student> GetStudentsByFacultyID(string ID)
        {
            return (from dbStudent in dbSt where dbStudent.FacultyID == ID select new Student(dbStudent.FirstName, dbStudent.SecondName, int.Parse(dbStudent.YearOfBirth),
                dbStudent.Departament, dbStudent.Marks)).ToList();
        }

        public List<Dekan> GetDekans()
        {
            return (from dbDekan in dbDek select new Dekan(dbDekan.FirstName, dbDekan.SecondName, dbDekan.YearOfBirth, dbDekan.Departament,
                dbDekan.Degree)).ToList();
        }

        public Dekan GetDekanByFacultyID(int ID)
        {
            return (from dbDekan in dbDek where dbDekan.FacultyID == ID select new Dekan(dbDekan.FirstName, dbDekan.SecondName, dbDekan.YearOfBirth, dbDekan.Departament,
                dbDekan.Degree)).First();
        }

        public Rector GetRector(string nameUniversity)
        {
            return (from dbRector in dbRec where GetUniversityID(nameUniversity) == dbRector.UnID.ToString() select new Rector(dbRector.FirstName, dbRector.SecondName, dbRector.YearOfBirth, dbRector.Departament)).First();
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

            return (from fac in dbFc where fac.UniversityID == ID select fac).ToList();
        }

        public List<University> GetUniversities()
        {

            List<University> universities = new List<University>();

            foreach (DBUniversity univ in dbUn)
            {

                University university = new University(univ.NameUniversity, GetAdressesByID(int.Parse(univ.AdressID)), GetRector(univ.NameUniversity));

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

    }
}