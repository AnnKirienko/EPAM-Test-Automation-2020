using System;


namespace University
{
    public class Person
    {
        public string firstName;
        public string secondName;

        // create construct without parametres
        public Person() 
        {
        }

        public string GetName(string name, string sname)
        {
            string fullName = firstName + secondName;
            firstName = name;
            secondName = sname;
            return fullName;
        }
    }
}
