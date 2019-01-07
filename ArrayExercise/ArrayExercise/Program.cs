using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("GoodBye");
            stringList.Add("Yo");

            Console.WriteLine("Please Select a number between 0 and 2");
            char input = Convert.ToChar(Console.ReadLine());

            if(input == '0')
            {
                Console.WriteLine(stringList[0]);
                Console.ReadLine();

            }else if (input == '1')
            {
                Console.WriteLine(stringList[1]);
                Console.ReadLine();

            } else if (input == '2'){

                Console.WriteLine(stringList[2]);
                Console.ReadLine();

            }

            List<int> numberList = new List<int>() {3,4,7,11,22,57 };
            Console.WriteLine("Please select a number between 0 and 5");
            char input2 = Convert.ToChar(Console.ReadLine());

            if (input2 == '0')
            {
                Console.WriteLine(numberList[0]);
                Console.ReadLine();

            } else if (input2 == '1')
            {
                Console.WriteLine(numberList[1]);
                Console.ReadLine();

            } else if (input2 == '2')
            {
                Console.WriteLine(numberList[2]);
                Console.ReadLine();

            } else if (input2 == '3')
            {
                Console.WriteLine(numberList[3]);
                Console.ReadLine();

            } else if (input2 == '4')
            {

                Console.WriteLine(numberList[4]);
                Console.ReadLine();
            } else if (input2 == '5')
            {

                Console.WriteLine(numberList[5]);
                Console.ReadLine();
            }
        }
    }
}
