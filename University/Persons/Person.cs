using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace University
{
    
    public class Person
    {
       
        string firstName;
        string secondName;
        string deprtament;
        int yearOfBirth;

       
        
        public string SecondName { get { return secondName; } set { secondName = value; } }

       
        public string FirstName { get { return firstName; } set { firstName = value; } }

       
        public string Departament { get {return deprtament; } set {deprtament = value; } }

       
        public int YearOfBirth { get {return yearOfBirth; } set {yearOfBirth = value; } }

        // create construct with parametres
        public Person(string firstName, string secondName, string departament, int yearOfBirth) 
        {
            this.yearOfBirth = yearOfBirth;
            this.firstName = firstName;
            this.deprtament = departament;
            this.secondName = secondName;
        }

        public Person()
        { }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            return person.firstName.Equals(this.firstName) && person.secondName.Equals(this.secondName) && person.yearOfBirth == this.yearOfBirth ;
        }

       
        public override string ToString()
        {
            return firstName + " " + secondName + " " + yearOfBirth + " " + deprtament;
        }

      
    }
}
