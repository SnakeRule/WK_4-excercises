﻿/*
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
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Amplifier amplifier = new Amplifier();

            do
            {
                Console.WriteLine("Set new volume value 1-100");
                amplifier.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Amp volume is now {0}", amplifier.Volume);
            } while (loop == true);
        }
    }
}
