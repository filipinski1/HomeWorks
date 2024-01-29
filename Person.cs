using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public bool IsEmployee { get; set; }

        public Person(string name, int age, string city, bool isEmployee)
        {
            Name = name;
            Age = age;
            City = city;
            IsEmployee = isEmployee;    
        }
    }


}
