using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSoft
{
    class StaffMember : Person

    {
        private float salary;

        // constrotor
        public StaffMember(string name, string gender, int age, string address, DateTime dateOfAddmission) : base(name, gender, age, address, dateOfAddmission)
        { }

        public void setSalary(float salary) { this.salary = salary; }
    }
}
