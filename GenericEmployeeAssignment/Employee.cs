using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEmployeeAssignment
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;
        public Employee(string firstName,string lastName,int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }
    }
}
