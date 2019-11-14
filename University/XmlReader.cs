using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace University
{
    class XmlReader
    {

        public List <Dictionary<string, string >> Load (string fileName, string nodeName, List<string> fieldsToLookFor)
        
        {
            List <Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("..\\..\\Resources\\" + fileName);

            XmlNodeList childNodes = xmlDocument.DocumentElement.SelectNodes(nodeName);
            foreach (XmlNode node in childNodes)
            {
                Dictionary<string, string> nodeValues = new Dictionary<string, string>();

                foreach (string fieldName in fieldsToLookFor) 
                {
                    XmlNode fieldNode = node.SelectSingleNode(fieldName);

                    if (fieldNode != null) 
                    {
                        nodeValues.Add(fieldName, fieldNode.InnerText);
                    }
                }

                result.Add(nodeValues);
            }

            return result;
        }
    }
}
