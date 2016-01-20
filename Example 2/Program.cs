using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Apina";
            person.LastName = "Saatana";
            person.Age = 6;
            person.Address = "Apinametsä";
            person.PhoneNumber = "3525242434324";

            Teacher teacher = new Teacher("Pylly", "Nalle", "D456");
            teacher.Address = ("Pyllynallekuja");
            teacher.Age = 30;
            teacher.PhoneNumber = "53454354";

            Student student = new Student("Jere","Valtanen","K1909");
            student.Address = "Can't tell :(";
            student.Age = 22;
            student.PhoneNumber = "54326546";


            Console.WriteLine(person.ToString());
            Console.WriteLine(teacher.ToString());
            Console.WriteLine(student.ToString());
            Console.ReadLine();
        }
    }
}
