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
            }
            catch ()
            {
            
            }
        }
    }
}
