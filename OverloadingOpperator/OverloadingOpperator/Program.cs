using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOpperator
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee()
            {
                FirstName = "James",
                LastName = "Jones",
                EmployeeId = 1
            };

            Employee employee2 = new Employee()
            {
                FirstName = "Tim",
                LastName = "Smith",
                EmployeeId = 2
            };

            Console.WriteLine(employee.EmployeeId == employee2.EmployeeId);
            Console.ReadLine();

            Console.WriteLine(employee.EmployeeId != employee2.EmployeeId);
            Console.ReadLine();
        }
    }
}
