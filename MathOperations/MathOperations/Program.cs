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
            MathStuff math = new MathStuff();

            Console.WriteLine("Which number would you like to run through the Math Guantlet?");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            MathStuff number = new MathStuff();
            int answer = number.addNumber(userNumber);
            Console.WriteLine(answer);
            Console.ReadLine();

            int answer2 = number.subtractNumber(userNumber);
            Console.WriteLine(answer2);
            Console.ReadLine();

            int answer3 = number.divideNumber(userNumber);
            Console.WriteLine(answer3);
            Console.ReadLine();

        }
    }
}
