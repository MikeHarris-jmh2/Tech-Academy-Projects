using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise3
{
    public class OverloadMethod
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void Individual(string f)
        {
            FirstName = f;
             
        }

        public void Individual(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }

        public void Individual( string f, string l, int a)
        {
            FirstName = f;
            LastName = l;
            Age = a;
        }
            


        
    }
}
