using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Boss boss = new Boss();

            employee.Name = "Masa Mainio";
            employee.Profession = "Crazy trash builder";
            employee.Salary = 50;

            boss.Name = "Big Boss";
            boss.Profession = "Badass";
            boss.Salary = 100000;
            boss.Car = "Horse";
            boss.Bonus = 100000;

            Console.WriteLine("Employee:");
            Console.WriteLine(employee.ToString());

            Console.WriteLine();
            Console.WriteLine("Boss:");
            Console.WriteLine(boss.ToString());

            employee.Profession = "Failure";
            employee.Salary = 0;

            Console.WriteLine();
            Console.WriteLine("Employee:");
            Console.WriteLine(employee.ToString());
        }
    }
}
