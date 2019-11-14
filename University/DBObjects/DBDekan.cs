using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    [XmlType("dekan")]
    public class DBDekan
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("secondName")]
        public string SecondName { get; set; }

        [XmlElement("departament")]
        public string Departament { get; set; }

        [XmlElement("yearOfBirth")]
        public int YearOfBirth { get; set; }

        [XmlElement("degree")]
        public string Degree { get; set; }

        [XmlElement("facultyID")]
        public int FacultyID { get; set; }
    }
}