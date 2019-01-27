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
            OptionalParameter parameter = new OptionalParameter();
            Console.WriteLine("Please provide one number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to provide a second optional number?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya")
            {
                Console.WriteLine("Please provide that second number now: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int finalNumber = parameter.divideNumber(firstNumber, secondNumber);
                Console.WriteLine(finalNumber);
                Console.ReadLine();
            }
            else
            {
                int finalNumber = parameter.divideNumber(firstNumber);
                Console.WriteLine(finalNumber);
                Console.ReadLine();
            }
        }
    }
}
