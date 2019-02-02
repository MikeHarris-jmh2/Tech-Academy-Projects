using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise3
{
    public class OverloadMethod
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }

        //public void Individual(string f)
        //{
        //    FirstName = f;
        //    Console.WriteLine(FirstName, LastName, Age);

        //}

        //public void Individual(string f, string l)
        //{
        //    FirstName = f;
        //    LastName = l;
        //    Console.WriteLine(FirstName, LastName, Age);
        //}

        public void Individual( string f, string l, int a)
        {
           string FirstName = f;
            string LastName = l;
            int Age = a;
            Console.WriteLine(FirstName + " " + LastName + " " + Age);
        }
            


        
    }
}
