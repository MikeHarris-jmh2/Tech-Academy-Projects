using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>() { "one", "two", "three" };

            Employee<int> employeeNumber = new Employee<int>() { 1, 2, 3, 4 };

            Console.WriteLine(employee);
            Console.Read();

            Console.WriteLine(employeeNumber);
            Console.Read();
        }
    }
}
