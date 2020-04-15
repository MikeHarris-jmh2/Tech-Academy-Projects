using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WelcomeExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Accounting Systems \n Remember, we're \"accounting\" on you!");
        }
    }
}
