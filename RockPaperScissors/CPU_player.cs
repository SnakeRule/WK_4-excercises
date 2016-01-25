/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 25.1.2016
*Author: Jere-Joonas Valtanen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class CPU_player : HandBase
    {
        // All we need to do here is generate random hands for the CPU

        Random rand = new Random();

        public void CpuHand()
        {
            Hand1 = rand.Next(1, 4);
            Hand2 = rand.Next(1, 4);
        }

    }
}
