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
            DateTime userHour = date.AddHours(usernumber);
            Console.WriteLine("The time will be " + userHour.TimeOfDay + " in {0} hours", usernumber);
            Console.ReadLine();
        }
    }
}
