  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Please provide a number: ");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The time will be " + date.AddHours(usernumber) + "in {0}", usernumber);
            Console.ReadLine();
        }
    }
}
