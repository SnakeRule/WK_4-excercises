using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 25.1.2016
*Author: Jere-Joonas Valtanen
*/

namespace RockPaperScissors
{
    class Player1 : HandBase
    {
        // Player1 gets the actual hand ints from HandBase, a method only here

            // Choosing hands
        public void Choosehands()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Left hand : Choose what to do");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Hand1 = int.Parse(Console.ReadLine());
                if (Hand1 >= 1 && Hand1 <= 3)
                    loop = false;
                else
                    loop = true;
            } while (loop == true);
            do
            {
                Console.WriteLine("Right hand : Choose what to do");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Hand2 = int.Parse(Console.ReadLine());
                if (Hand2 >= 1 && Hand2 <= 3)
                    loop = false;
                else
                    loop = true;
            } while (loop == true);
            Console.Clear();
        }
    }
}
