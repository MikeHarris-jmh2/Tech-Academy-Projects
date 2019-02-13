using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOpperator
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

        public virtual void ListEmployees()
        {
            foreach (Person employee in Employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if(employee == employee2)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if(employee != employee2)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
