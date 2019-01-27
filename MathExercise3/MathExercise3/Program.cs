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
            MathOverload numberOverload = new MathOverload();
            numberOverload.DividebyTwo(userNumber);
            Console.WriteLine(userNumber);
            Console.ReadLine();

            OverloadMethod overload = new OverloadMethod();

            overload.Individual("Mike", "Example", 21);

            Console.WriteLine(overload);
        }
    }
}
