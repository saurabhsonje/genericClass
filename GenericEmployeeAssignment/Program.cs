using System;

namespace GenericEmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Saurabh", "Sonje", 23000);
            Employee emp1 = new Employee("Saurabh", "Sonje", 23000);
            Employee emp2 = new Employee("Saurabh", "Sonje", 23000);
            Employee emp3 = new Employee("Saurabh", "Sonje", 23000);
            Employee emp4 = new Employee("Saurabh", "Sonje", 23000);
            Employee emp5 = new Employee("Saurabh", "Sonje", 23000);
            Customer cust = new Customer("Saurabh1", "Sonje1", 23);
            PersonRepository<Employee> obj = new PersonRepository<Employee>();
            obj.AddPerson(emp);
            obj.AddPerson(emp1);
            obj.AddPerson(emp2);
            obj.AddPerson(emp3);
            obj.AddPerson(emp4);
            obj.AddPerson(emp5);
            //obj.AddPerson(cust);
            Console.ReadLine();
        }
    }
}
