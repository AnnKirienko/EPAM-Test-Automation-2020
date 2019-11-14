using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    [XmlType("university")]
    public class DBUniversity
    {
        [XmlElement("name")]
        public string NameUniversity { get; set; }
        [XmlElement("unID")]
        public string UnID { get; set; }
        [XmlElement("adressID")]
        public string AdressID { get; set; }
    }
}
