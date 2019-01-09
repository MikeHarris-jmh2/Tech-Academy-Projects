using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    class Employee : Person
    {
        public int EmployeeId { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

    }
}
