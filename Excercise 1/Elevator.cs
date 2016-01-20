/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 20.1.2016
*Author: Jere-Joonas Valtanen
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Elevator
    {
        // Member field
        private int floor = 1;

        // Properties
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > 0 && value < 6)
                    floor = value;
                else if (value < 1)
                {
                    Console.WriteLine("That floor is too low. Try again");
                }
                else Console.WriteLine("That floor is too high. Try again");
            }
        }
    }
}
