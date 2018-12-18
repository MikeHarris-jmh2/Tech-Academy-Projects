using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Which number do you want to multiply by 50?");
            int pageNumber = Convert.ToInt32(Console.ReadLine()) * 50 ;
            Console.Write(pageNumber);
            Console.Read();

            Console.WriteLine("Which number do you want to add 25 to");
            int pageNumber2 = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.Write(pageNumber2);
            Console.Read();

            Console.WriteLine("Which number do you want to be divided by 12.5");
            double pageNumber3 = double.Parse(Console.ReadLine()) / 12.5;
            Console.Write(pageNumber3);
            Console.Read();

            Console.WriteLine("Please provide your favorite number");
            int favNumber = Convert.ToInt32(Console.ReadLine());
            if(favNumber < 50)
            {
                Console.WriteLine("True");
                Console.Read();
            }
            else
            {
                Console.WriteLine("False");
                Console.Read();
            }

            Console.WriteLine("Please insert a number and we will return the remainder");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.Read();

        }
    }
}
