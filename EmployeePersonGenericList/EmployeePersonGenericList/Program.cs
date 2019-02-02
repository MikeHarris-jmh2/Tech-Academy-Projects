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
                Things = new List<string>() 
            };
            employees.Things.Add("String1");
            employees.Things.Add("String2");
            employees.Things.Add("String3");
            employees.Things.Add("String4");

            Employee<int> employeeNumbers = new Employee<int>
            {
                Things = new List<int>() 
            };
            employeeNumbers.Things.Add(1);
            employeeNumbers.Things.Add(2);
            employeeNumbers.Things.Add(3);
            employeeNumbers.Things.Add(4);

            employees.Things.ForEach(Console.WriteLine);
            Console.ReadLine();

            employeeNumbers.Things.ForEach(Console.WriteLine);
            Console.ReadLine();

           
        }
    }
}
