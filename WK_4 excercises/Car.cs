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

namespace WK_4_excercises
{
    class Car
    {
        //max speed
        private readonly int maxspeed = 200;
        // member field
        private int speed;
        //Property
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxspeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed - speed set to maximum!");
                    speed = maxspeed;
                }
            }
        }
    }
}
