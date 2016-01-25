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

namespace Excercise_6
{
    class GameConsole : Game
    {
        private bool handheld;

        public bool Handheld
        {
            get
            {
                return handheld;
            }
            set
            {
                if (value == true)
                    handheld = true;
                else
                    handheld = false;
            }
        }

        public void EnterDataGameConsole()
        {
            bool loop = true;
            do
            {
                int input;
                Console.WriteLine("Is the console a handheld? 1 = yes 0 = no");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Handheld = true;
                    loop = false;
                }
                else if (input == 0)
                {
                    Handheld = false;
                    loop = false;
                }
                else
                    Console.WriteLine("Try again");
            } while (loop == true);

            Console.WriteLine("What disc format does the console use?");
            Discformat = Console.ReadLine();

            Type = "Game Console";
        }

        public void PrintDataGameConsole()
        {
            if (Handheld == true)
                Console.WriteLine("The console is a handheld");
            else
                Console.WriteLine("The console is not a handheld");

            Console.WriteLine("Disc format: {0}", Discformat);
        }
    }
}
