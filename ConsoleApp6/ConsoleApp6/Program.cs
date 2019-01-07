using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide another number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            OptionalParameter parameter = new OptionalParameter();
            int finalNumber = parameter.divideNumber(firstNumber, secondNumber);
            Console.WriteLine(finalNumber);



        }
    }
}
