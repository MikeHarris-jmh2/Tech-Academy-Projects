using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class OptionalParameter
    {
        public int divideNumber(int a, int b = 0)
        {
            int c = (a + b) / 2;
            return c;
        }
    }
}
