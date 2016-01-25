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
    class Book : Item_base
    {
        private int pageNmb;

        public int PageNmb
        {
            get
            {
                return pageNmb;
            }
            set
            {
                pageNmb = value;
            }
        }

        public void EnterDataBook()
        {
            Console.WriteLine("Enter page amount");
            PageNmb = int.Parse(Console.ReadLine());

            Type = "Book";
        }

        public void PrintDataBook()
        {
            Console.WriteLine("Book page amount : {0}", PageNmb);
        }
    }
}
