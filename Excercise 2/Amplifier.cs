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

namespace Excercise_2
{
    class Amplifier
    {
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > -1 && value < 101)
                {
                    volume = value;
                }
                else if (value < 0)
                    Console.WriteLine("You can't set the volume below 0!");

                else
                    Console.WriteLine("You can't set the volume above 100!");
            }
        }
    }
}
