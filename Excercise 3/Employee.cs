using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Employee
    {
        protected string name;
        protected string profession;
        protected int salary;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return "- Name: " + name + " Profession: " + profession + " Salary: " + salary;
        }
    }
}
