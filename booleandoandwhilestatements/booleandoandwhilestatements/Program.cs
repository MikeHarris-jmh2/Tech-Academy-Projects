using System;

namespace booleandoandwhilestatements
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            
            while(number < 25)
            {
                Console.WriteLine(number);
                Console.ReadLine();
                number++;
                
            }


            int number2 = 0;
            do
            {
                Console.WriteLine(number2);
                number2++;
            } while (number2 < 10);


        }
    }
}
