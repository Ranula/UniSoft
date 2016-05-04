using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSoft;


namespace UniSoft
{
    class Parent : Person
    {
        private Student[] children;//

       public Parent(string name,string gender,int age,string address): base(name,gender,age,address)
        { }

       
        

        public void getMarks(student child)
        { //cheak the avalability of the studeen
            foreach (Student student in children)
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
