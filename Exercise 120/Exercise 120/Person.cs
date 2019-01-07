using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Please provide a first name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please provide a last name:");
            string LastName = Console.ReadLine();

            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            

        }
    }
}
