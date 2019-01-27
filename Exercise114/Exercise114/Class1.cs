using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise114
{
    class IntegerReturn
    {
        public int MathOp(int a)
        {
            Console.WriteLine("Please provide a number");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = c + 4;
            return d;
            
        }

        public decimal MathOp(decimal a)
        {
            Console.WriteLine("Please provide a decimal number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = b - 3;
            return c;
           
        }

        public int MathOp(string a)
        {
            Console.WriteLine("Please provide a string");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = b / 5;
            return c;

        }
    }
}
