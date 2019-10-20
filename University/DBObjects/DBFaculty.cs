using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    [XmlType("faculty")]
    public class DBFaculty
    {
        [XmlElement("facultID")]
        public int FacultyID { get; set; }
        [XmlElement("adressID")]
        public int AdressID { get; set; }
        [XmlElement("name")]
        public string NameDepartament { get; set; }
        [XmlElement("universityName")]
        public string UniversityName { get; set; }
        [XmlElement("unID")]
        public int UniversityID { get; set; }
       
    }
}
