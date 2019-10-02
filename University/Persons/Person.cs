using System;


namespace University
{
    public class Person
    {
        string firstName;
        string secondName;
        int yearOfBirth;

        // create construct with parametres
        public Person(string firstName,string secondName,int yearOfBirth) 
        {
            this.yearOfBirth = yearOfBirth;
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            return person.firstName.Equals(this.firstName) && person.secondName.Equals(this.secondName) && person.yearOfBirth == this.yearOfBirth ;
        }

       
        public override string ToString()
        {
            return firstName + " " + secondName + " " + yearOfBirth;
        }
    }
}
