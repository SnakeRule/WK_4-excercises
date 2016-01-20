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
            bool loop = true;
            Elevator elevator = new Elevator();

            Console.WriteLine("Welcome to the elevator");
            do
            {
                Console.WriteLine("Elevator is now in floor {0}", elevator.Floor);
                Console.WriteLine("Choose a floor 1-5");
                elevator.Floor = int.Parse(Console.ReadLine());
            } while (loop == true);
        }
    }
}
