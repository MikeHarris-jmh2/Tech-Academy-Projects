using System;


namespace BooleanExercise.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insuarance Agency Corp Yeah");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Yes or No");
            string duiAnswer = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            if(age > 14 && duiAnswer == "No" && speedingTickets < 3)
            {
                Console.WriteLine("You are eligible for Insurance");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Sorry, you are uneligible for Insurance");
                Console.ReadLine();
            }
        }
    }
}
