using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_6
{
    class Game : Item_base
    {
        private string platform;
        private string discFormat;

        public string Platform
        {
            get
            {
                return platform;
            }
            set
            {
                platform = value;
            }
        }

        public string Discformat
        {
            get
            {
                return discFormat;
            }
            set
            {
                discFormat = value;
            }
        }

        public void EnterDataGame()
        {
            Console.WriteLine("Enter game platform");
            Platform = Console.ReadLine();

            Console.WriteLine("Enter disc format");
            Discformat = Console.ReadLine();

            Type = "Video Game";
        }

        public void PrintDataGame()
        {
            Console.WriteLine("Game platform: {0}", Platform);

            Console.WriteLine("Game disc format: {0}", Discformat);
        }
    }
}
