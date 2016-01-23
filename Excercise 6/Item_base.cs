using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_6
{
    class Item_base
    {
        protected string name;
        protected string type;
        protected int shelf_nmb;
        protected int shelf_lvl;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        protected string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        protected int Shelf_nmb
        {
            get
            {
                return shelf_nmb;
            }
            set
            {
                bool loop = true;
                do
                {
                    if (value <= 3 && value >= 1)
                    {
                        shelf_nmb = value;
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("No such shelf number! Try again.");
                        value = int.Parse(Console.ReadLine());
                    }
                } while (loop == true);
            }
        }

        protected int Shelf_lvl
        {
            get
            {
                return shelf_lvl;
            }
            set
            {
                bool loop = true;
                do
                {
                    if (value <= 6 && value >= 1)
                    {
                        shelf_lvl = value;
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("No such shelf level! Try again.");
                        value = int.Parse(Console.ReadLine());
                    }
                } while (loop == true);
            }
        }
            
        public void EnterData()
        {
            Console.WriteLine("Enter item name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter shelf number 1-3");
            Shelf_nmb = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter shelf level 1-6");
            Shelf_lvl = int.Parse(Console.ReadLine());
        }


        public void PrintData()
        {
            Console.WriteLine("Item type: {0}", type);
            Console.WriteLine("Item name: {0}", name);
            Console.WriteLine("Shelf number: {0}", shelf_nmb);
            Console.WriteLine("Shelf level: {0}", shelf_lvl);
        }
    }
}
