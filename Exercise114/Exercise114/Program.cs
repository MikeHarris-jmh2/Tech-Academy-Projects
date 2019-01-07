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
            example_Integer.AddDecimal(99.9);
            example_Integer.AddInteger(2);
            example_Integer.AddString("2");
        }
    }
}
