using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise3
{
     static class Static_class
    {
        public static string firstName { get; set; }
        public static string lastName { get; set; }

        public static string sayName(string firstName, string lastName)
        {
            firstName = "Mike";

            lastName = "Example";

           string fullName = firstName + " " + lastName;

            return fullName;

        }
    }
}
