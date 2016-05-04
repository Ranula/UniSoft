using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSoft;


namespace UniSoft
{
    class Parent
    {
        private String name;
        private student[] students;
        private string adress;

        public String getName()
        {
            return this.name;
        }
        private string getAdress()
        {
            return adress;
        }

        public void getMarks(student child)
        { //cheak the avalability of the studeen
            foreach (student student in students)
            {
                if (student == chid)
                {

                }
                else
                {   
                    Console.WriteLine("No such a student for the parent");
                }
            }
        }

    }


}
}
