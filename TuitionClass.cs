using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSoft
{
    class TuitionClass
    {


        private ClassHall classhall;
        private Teacher teacher;
        public String subject;
        private int numofStudents;
        public TuitionClass(ClassHall h, Teacher t, String subject)
        {
            this.classhall = h;
            this.teacher = t;
            this.subject = subject;
        }
        public Teacher getTeacher()
        {
            return teacher;
        }

        public void changeteacher(Teacher t)
        {
            this.teacher = t;
        }

        public int getnumofstudents()
        {
            return numofStudents;
        }


    }

}


