using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            int person1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.Read();

            Console.WriteLine("Hours worked per week?");
            int person1WorkWeek = Convert.ToInt32(Console.ReadLine());
            Console.Read();

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            int person2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.Read();

            Console.WriteLine("Hours worked per week?");
            int person2WorkWeek = Convert.ToInt32(Console.ReadLine());
            Console.Read();

            Console.WriteLine("Weekly salary of Person 1: ");
            int person1WeeklySalary = person1Hourly * person1WorkWeek;
            Console.WriteLine(person1WeeklySalary);
            Console.Read();

            Console.WriteLine("Weekly salary of Person 2: ");
            int person2WeeklySalary = person2Hourly * person2WorkWeek;
            Console.WriteLine(person2WeeklySalary);
            Console.Read();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if(person1WeeklySalary > person2WeeklySalary)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
