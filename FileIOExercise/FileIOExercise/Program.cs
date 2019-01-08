using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:C:\Users\Student\logs\log.txt", true))
            {
                file.WriteLine(number);
            }

        }
    }
}
