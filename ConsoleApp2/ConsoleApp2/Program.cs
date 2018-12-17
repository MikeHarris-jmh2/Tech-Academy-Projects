using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseProgression = Console.ReadLine();

            Console.WriteLine("What Page Number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? True or False");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
           
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positive = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

        }
    }
}
