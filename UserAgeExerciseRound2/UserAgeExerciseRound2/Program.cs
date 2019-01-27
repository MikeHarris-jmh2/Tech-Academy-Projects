using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace UserAgeExerciseRound2
{
    public class Program
    {
        public static void Main()
        {
            

            try
            {
                Console.WriteLine("How old are you?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                int year = Convert.ToInt32(DateTime.Now.Year);
                int yearOfBirth = year - userAge;
                Console.WriteLine(yearOfBirth);
            }
            catch (Exception)
            {
                Console.WriteLine("Please do not put 0 or negative numbers.");
            }
        }
    }
}
