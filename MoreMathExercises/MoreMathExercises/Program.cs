using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMathExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide another number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            MathOperations operation = new MathOperations();
            int answerNumber = operation.addNumber(number, number2);
            Console.WriteLine(answerNumber);
            Console.ReadLine();
        }
    }
}
