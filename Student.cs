using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSoft
{
    class student : Person

    //
    {
        private char id;
        private Parent p;



        //constuctor to add accept name and the age when creating the object

        public student(string name, string gender, int age, string address, DateTime dateOfAddmission) : base(name, gender, age, address, dateOfAddmission)
        {

        }
        // getters

        public int getId()
        {
            return id;
        }

        public Parent getParent()
        {
            return p;
        }

        public void setParent(Parent parent)
        {

        }

    }
}


