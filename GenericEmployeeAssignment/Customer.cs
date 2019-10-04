using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEmployeeAssignment
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Customer(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
