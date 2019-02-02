using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please provide a number you would like to be divided by 2");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int a;
            MathOverload.DividebyTwo(userNumber, out a);
            

            OverloadMethod overload = new OverloadMethod();
            Console.WriteLine("Please enter your name");
            string fName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int userAge = Convert.ToInt32(Console.ReadLine());


            //overload.Individual("Mike", "Example", 21);
            overload.Individual(fName, lName, userAge);

          
           





            Console.ReadLine();




        }
    }
}
