using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSoft
{
    // inherit from the super class
    class Student : Person
 
    {
        private Parent parent;
        private int ID;
        // constroctor     
        public Student(string name, string gender, int age, string address, DateTime dateOfAddmission) : base(name, gender, age, address, dateOfAddmission)
        {
        }

        public void setParent(Parent parent) {this.parent = parent;}

        public void setId(int id) { this.ID = id; }

        public Parent getParent() { return parent; }

        public int getId() { return ID; }
        

    }
}
