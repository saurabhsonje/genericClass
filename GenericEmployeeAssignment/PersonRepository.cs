using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEmployeeAssignment
{
    public class PersonRepository<T>
    {
        public static List<T> list = new List<T>();

        public void AddPerson(T obj)
        {
            list.Add(obj);


        }
    }
}
