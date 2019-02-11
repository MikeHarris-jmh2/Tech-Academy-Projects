using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise124
{
    class Employee : Person
    {

        public int EmployeeId { get; set; }
        public List<Person> Employees { get; set; }


        public override void SayName()
        {
            Console.WriteLine("Please provide a First Name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please provide a Last Name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }
    }
}
