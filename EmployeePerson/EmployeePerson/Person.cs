using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePerson
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Please provide a First Name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please provide a Last Name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
