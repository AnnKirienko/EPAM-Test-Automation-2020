using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    [XmlType("student")]
    //[JsonObject(MemberSerialization.OptIn)]
    public class DBStudent
    {
        [XmlElement("firstName")]
       // [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
       // [JsonProperty(PropertyName = "secondName")]
        [XmlElement("secondName")]
        public string SecondName { get; set; }
      //  [JsonProperty(PropertyName = "faculty")]
        [XmlElement("faculty")]
        public string Departament { get; set; }
      //  [JsonProperty(PropertyName = "yearOfBirth")]
        [XmlElement("yearOfBirth")]
        public string YearOfBirth { get; set; }
       // [JsonProperty(PropertyName = "marks")]
        [XmlElement("marks")]
        public string Marks { get; set; }
      //  [JsonProperty(PropertyName = "facultID")]
        [XmlElement("facultID")] 
       public string FacultyID { get; set; }
    }
}
