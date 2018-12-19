using System;


namespace PackageExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            Console.WriteLine("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if(packageWeight > 50)
            {
                Console.WriteLine("Your Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Please enter the package height: ");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Please enter the package length: ");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                int packageDimensions = packageHeight + packageWidth + packageLength;

                if(packageDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                } else
                {
                    decimal totalDimensions = packageHeight * packageLength * packageLength;

                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + totalDimensions);
                    Console.ReadLine();
                }
            }
        }
    }
}
