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

{
    class HandBase
    {
        //This is the base for the game. Hand values are here, also score values

        private int hand1;
        private int hand2;
        private int hand1Score;
        private int hand2Score;

        public int Hand1
        {
            get
            {
                return hand1;
            }
            set
            {
                if (value >= 1 && value <= 3)
                    hand1 = value;
                else hand1 = 0;
            }
        }
        public int Hand2
        {
            get
            {
                return hand2;
            }
            set
            {
                if (value >= 1 && value <= 3)
                    hand2 = value;
                else hand2 = 0;
            }
        }

        public int Hand1Score
        {
            get
            {
                return hand1Score;
            }
            set
            {
                hand1Score = value;
            }
        }

        public int Hand2Score
        {
            get
            {
                return hand2Score;
            }
            set
            {
                hand2Score = value;
            }
        }

        // Prints out player hand choices

        public void Revealhands()
        {
            if (Hand1 == 1)
                Console.WriteLine("Left hand : Rock");
            else if (Hand1 == 2)
                Console.WriteLine("Left hand : Paper");
            else
                Console.WriteLine("Left hand : Scissors");

            if (Hand2 == 1)
                Console.WriteLine("Right hand : Rock");
            else if (Hand2 == 2)
                Console.WriteLine("Right hand : Paper");
            else
                Console.WriteLine("Right hand : Scissors");
        }

    }
}
