using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class student
    {
        private string name;
        private string age;
        private string gender;
        private char id;
        private DateTime birthday;
        private string address;


        //constuctor to add accept name and the age when creating the object

        public student(string name, string age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            Console.WriteLine("student has created!!");

        }
        // getters
        public string getName()
        {
            return name;

        }
        public string getAge()
        {
            return age;
        }
        public string getAddress()
        {
            return address;
        }
        public int getId()
        {
            return id;
        }
        public string getGenger()
        {
            return gender;
        }

    }
}
