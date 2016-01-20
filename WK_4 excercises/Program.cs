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
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 300;
            Console.WriteLine("Car speed is {0}", car.Speed);
            Console.ReadLine();
        }
    }
}
