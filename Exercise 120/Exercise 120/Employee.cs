using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    public class Employee<T> : Person, IQuittable
    {
        public int EmployeeId { get; set; }
        public T Things  { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit(Employee employee)
        {

        }

    }
}
