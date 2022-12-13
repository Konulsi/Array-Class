using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone;
        public int zipCode;


        public string GetFullName()
        {
            return name + " " + surname;
        }


        public string GetFullData(int zipCode = 4444)
        {
            return $" {name} {surname} {age} {address} {phone} {zipCode}";
                
        }
    }
}
