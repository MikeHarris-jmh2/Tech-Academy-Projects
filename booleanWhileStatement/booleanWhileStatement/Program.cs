using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            int number2 = 0;

            while (number < 10)
            {
                Console.WriteLine("Hello There", number);
                Console.ReadLine();
                number++;

            }

            do
            {
                Console.WriteLine("The number is {0}", number2);
                Console.ReadLine();
                number2++;
            } while (number2 < 12);

        }
    }
}
