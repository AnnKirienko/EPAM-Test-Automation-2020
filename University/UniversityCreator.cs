using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    public class UniversityCreator
    {
        IDBProvider prov = new XmlDBProvider();

        public List <University> GetUniversities()
        {
           
            return prov.GetUniversities();
        }

    }
}
