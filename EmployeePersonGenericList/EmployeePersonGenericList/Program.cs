using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePersonGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employees = new Employee<string>
            {
                Things = new List<string>() { "string 1", "string 2", "string 3"}
            };

            Employee<int> employeeNumbers = new Employee<int>
            {
                Things = new List<int>() { 1, 2, 3, 4 }
            };

            Console.WriteLine(employees);
            Console.ReadLine();

            Console.WriteLine(employeeNumbers);
            Console.ReadLine();

           
        }
    }
}
