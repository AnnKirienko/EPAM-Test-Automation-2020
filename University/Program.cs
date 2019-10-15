using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {

            IDBProvider provider = new XmlDBProvider();
           

            foreach (Faculty facult in provider.GetFaculties())
                Console.WriteLine(facult);
          



            
            

        }
    }
}
