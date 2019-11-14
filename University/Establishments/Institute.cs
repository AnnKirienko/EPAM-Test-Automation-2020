using System;
using System.Collections.Generic;
using System.Linq;



namespace University
{
   public class Institute : Departament
    {
       Manager manager;
       //Employee[] arrayEmployee = new Employee[2];

       List<Employee> listEmployee = new List<Employee>();

       public Institute (string name, Adress adr,string universityName, Manager man ) : base(name, adr,universityName)
       {
            manager = man;
       }

       public override string ToString()
       {
           string employeeStr = "";
           foreach (Employee employee in listEmployee)
               employeeStr += (" " + employee);

           return base.ToString() + " " + manager + " " + employeeStr;
       }

            bool CanBeAdded(Employee employee)
       {

           foreach (Employee empl in listEmployee)
           {
               if (empl != null && empl.Equals(employee))
               {
                   return false;
               }
           }
           return true;
       }

       public bool AddEmployee(Employee employee)
       {
           if ((listEmployee.Count < 2) && this.CanBeAdded(employee))
           {
               listEmployee.Add(employee);
               Console.WriteLine("Adding " + employee);
               return true;
           }
           return false;

       }
    }
}
