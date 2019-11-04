using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace University
{
    [XmlType("adress")]
   public class DBAdress
    {
        [XmlElement("cityAdr")]
        public string CityAdr { get; set; }
        [XmlElement("streetAdr")]
        public string StreetAdr { get; set; }
        [XmlElement("buildingAdr")]
        public string BuildingAdr { get; set; }
        [XmlElement("adressID")]
        public int AdressID { get; set; }
    }
}
