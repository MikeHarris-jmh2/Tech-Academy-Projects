﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePerson
{
    public abstract class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public abstract void SayName();

       

       
    }
}
