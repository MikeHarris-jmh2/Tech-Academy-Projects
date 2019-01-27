using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePerson
{
    public class Employee : Person
    {
        public List<Person> People { get; set; }
        public int EmployeeId { get; set; }
    }
}
