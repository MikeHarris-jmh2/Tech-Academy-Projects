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
            int d = c + 2;
            return d;
            
        }

        public decimal MathOp(decimal a)
        {
            Console.WriteLine("Please provide a decimal number");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            int d = Convert.ToInt32(b);
            int c = d - 1;
            return c;
            
           
        }

        public int MathOp(string a)
        {
            Console.WriteLine("Please provide a string");
            string b = Console.ReadLine();
            int d = Convert.ToInt32(b.Length); 
            int c = d / 2;
            return c;

        }
    }
}
