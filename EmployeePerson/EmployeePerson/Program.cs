using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeePerson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> employees = new List<Person>();
            Employee employee = new Employee();
            employee.SayName();
            employees.Add(employee);

            foreach (var person in employees)
            {
                employees.Add(person);
                Console.WriteLine(person);
                Console.ReadLine();
            }
        }       
    }
}
