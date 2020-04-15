using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114
{
    class Program
    {
        static void Main(string[] args)
        {
             IntegerReturn example_Integer = new IntegerReturn();
            var decimalEx = example_Integer.MathOp(99.9m);
            var intEx = example_Integer.MathOp(2);
            var stringEx = example_Integer.MathOp("Hello");

            Console.WriteLine("Here is result for your decimal: " + decimalEx);
            Console.ReadLine();

            Console.WriteLine("Here is the result for your int: " + intEx);
            Console.ReadLine();

            Console.WriteLine("Here is the result for your string: " + stringEx);
            Console.ReadLine();
        }
    }
}
