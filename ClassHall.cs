using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSoft
{
    class ClassHall
    {
        private int ClassHallno;
        private int Capasity;
        // Hashtable timeslots = new Hashtable();

        //Constructor
        public ClassHall(int HallNO)
        {
            this.ClassHallno = HallNO;
        }

        public void SetCapasity(int num)
        {
            this.Capasity = num;
        }

        public int getCapasity()
        {
            return Capasity;
        }

        public int getHallNo()
        {
            return ClassHallno;
        }

        /* public void addTimeSlot(String Date,String Time)
         {
             timeslots.Add(Date, Time);
         }*/




    }
}
