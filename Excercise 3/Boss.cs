﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Boss : Employee
    {
        private string car;
        private int bonus;

        public string Car
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        }
        public int Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }

        public override string ToString()
        {
            return "- Name: " + name + " Profession: " + profession + " Salary: " + salary + " Car: " + car + " Bonus: " + bonus;
        }
    }
}
