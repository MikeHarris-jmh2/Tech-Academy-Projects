using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePerson
{
    public class Employee : Person, IQuittable
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

        public static Employee operator== (Employee employee, Employee employee2)
        {
            return employee == employee2;
        }

        public static Employee operator!= (Employee employee, Employee employee2)
        {
            return employee != employee2;
        }

        public void  Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
