using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace University
{
  [XmlType("student")]
  public class DBStudent
  {
    [XmlElement("firstName")]
    public string FirstName { get; set; }

    [XmlElement("secondName")]
    public string SecondName { get; set; }

    [XmlElement("faculty")]
    public string Departament { get; set; }

    [XmlElement("yearOfBirth")]
    public string YearOfBirth { get; set; }

    [XmlElement("marks")]
    public string Marks { get; set; }

    [XmlElement("facultID")]
    public string FacultyID { get; set; }
  }
}