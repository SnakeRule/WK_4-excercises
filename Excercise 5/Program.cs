/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 23.1.2016
*Author: Jere-Joonas Valtanen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            bool loop = true;
            int input;
            do
            {
                Console.WriteLine();
                if (radio.power_on == true)
                    Console.WriteLine("The radio is on");
                else
                    Console.WriteLine("The radio is off");
                Console.WriteLine("Radio volume is {0} and the frequency is {1}", radio.Volume, radio.Frequency);
                Console.WriteLine("1. Power On/Off");
                Console.WriteLine("2. Change volume");
                Console.WriteLine("3. Change frequency 2000,0-26000,0");
                Console.WriteLine("4. Quit");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        if (radio.power_on == false)
                            radio.power_on = true;
                        else
                            radio.power_on = false;
                        break;
                    case 2:
                        {
                            Console.Write("Set volume 0-9");
                            radio.Volume = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Set frequency 2000,0-26000,0");
                            radio.Frequency = double.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        loop = false;
                        break;
                }
            } while (loop == true);
        }
    }
}
