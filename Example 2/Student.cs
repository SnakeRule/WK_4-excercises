using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Student : Person
    {
        public string StudentID;


        public Student()
        {

        }

        public Student(string firstName, string lastName, string studentID) 
            : base(firstName,lastName)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
