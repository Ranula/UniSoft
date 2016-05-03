using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSoft
{
    abstract class Person
    { 
    // variables
        protected string name;
        protected string gender;
        protected int age;
        protected string address;
        protected DateTime dateOfAddmission;

    // constroctor
        public Person(string name,string gender,int age,string address,DateTime dateOfAddmission)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.dateOfAddmission = dateOfAddmission;

        }
   // setters
        public string getName()
        {
            return name;
        }

        public string getGender()
        {
            return gender;
        }

        public int getAge()
        {
            return age;
        }

        public DateTime getDateOfAddmission()
        {
            return dateOfAddmission;
        }
    }
}
