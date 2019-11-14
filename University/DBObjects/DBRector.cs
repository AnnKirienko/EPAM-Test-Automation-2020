using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    [XmlType("rector")]
    public class DBRector
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("secondName")]
        public string SecondName { get; set; }

        [XmlElement("university")]
        public string Departament { get; set; }

        [XmlElement("yearOfBirth")]
        public int YearOfBirth { get; set; }

        [XmlElement("unID")]
        public int UnID { get; set; }
    }
}
