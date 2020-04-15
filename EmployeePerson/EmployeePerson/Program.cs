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
            employees[0].FirstName = "Joe";
            employees[0].LastName = "John";
            employees.Add(new Employee());
            employees[1].FirstName = "Sam";
            employees[1].LastName = "Smith";
            employees.Add(new Employee());
            employees[2].FirstName = "Joe";
            employees[2].LastName = "Andrews";
            employees.Add(new Employee());
            employees[3].FirstName = "Tom";
            employees[3].LastName = "Hardy";
            employees.Add(new Employee());
            employees[4].FirstName = "Alex";
            employees[4].LastName = "Hinge";
            employees.Add(new Employee());
            employees[5].FirstName = "Striker";
            employees[5].LastName = "Force";
            employees.Add(new Employee());
            employees[6].FirstName = "Rach";
            employees[6].LastName = "Alstote";
            employees.Add(new Employee());
            employees[7].FirstName = "Quin";
            employees[7].LastName = "Harris";
            employees.Add(new Employee());
            employees[8].FirstName = "Stan";
            employees[8].LastName = "Slim";
            employees.Add(new Employee());
            employees[9].FirstName = "Joe";
            employees[9].LastName = "Jorgenson";
            employees.ForEach(Console.WriteLine);
            Console.ReadLine();


          foreach(Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    List<Person> joeEmployees = new List<Person>();
                    joeEmployees.Add(employee);
                    joeEmployees.ForEach(Console.WriteLine);
                    Console.ReadLine();
                }

                if(employee.EmployeeId > 5)
                {
                    List<Person> fiveEmployee = new List<Person>();
                    fiveEmployee.Add(employee);
                    fiveEmployee.ForEach(Console.WriteLine);
                    Console.ReadLine();
                }
            }


        }
    }
}
