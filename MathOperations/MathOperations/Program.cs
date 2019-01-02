using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Which number would you like to run through the Math Guantlet?");
           public int userNumber = Convert.ToInt32(Console.ReadLine());

            MathStuff.addNumber(userNumber);


        }
    }
}
