using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
    public class Person
    {
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string phone, int age)
        {
            Age = age;
            PhoneNumber = phone;
        }
    }
}
