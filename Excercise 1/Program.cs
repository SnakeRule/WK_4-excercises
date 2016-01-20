using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Elevator elevator = new Elevator();

            Console.WriteLine("Welcome to the elevator. You can leave the elevator by pressing 0");
            do
            {
                Console.WriteLine("Elevator is now in floor {0}", elevator.Floor);
                Console.WriteLine("Choose a floor 1-5");
                input = int.Parse(Console.ReadLine());
                elevator.Floor = input;
            } while (input != 0);
        }
    }
}
