using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
   interface IDBProvider
    {
        Adress GetAdress (string nameUniversity);

     //   List<Departament> GetDepartaments();
       
         List<Faculty> GetFaculties(string nameUniversity);

        //void SaveStudent(Student student, string facultID);


       //  List<Autocade> GetAutocades();


        //  List<Institute> GetInstitutes();

        // List<Staff> GetStaffes();


        //  List<Car> GetCars();

        //  List<Garage> GetGarages();

        //  List<Accountant> GetAccountants();

        List<Dekan> GetDekans();

         // List<Employee> GetEmployees();

         //List<Head> GetHeads();
         //List<Manager> GetManagers();
          List<Student> GetStudents();

         List<University> GetUniversities();
       

//       //public List<> Get()
//       //{}

//       //public List<> Get()
//       //{}

//       //public List<> Get()
//       //{}

//       //public List<> Get()
//       //{}



}
}
