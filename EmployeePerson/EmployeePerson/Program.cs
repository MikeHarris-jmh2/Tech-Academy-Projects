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
            employees.Add(new Employee());
            employees[0].FirstName = "Sample";
            employees[0].LastName = "Student";
            employees.Add(new Employee());
            employees[1].FirstName = "Example";
            employees[1].LastName = "Member";

            foreach(Employee person in employees)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);

                if (person.EmployeeId == person.EmployeeId)
                {
                    Console.WriteLine("These employees are the same person");
                } else
                {
                    Console.WriteLine("These employees are not the same");
                }
            }

            Console.ReadLine();


        }       
    }
}
