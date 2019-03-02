using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oddArray = new int[6] { 1, 5, 2, 4, 6, 7};
            int total = 0;

            for(int i = 0; i < oddArray.Length; i++)
            {
                if( i % 2 != 0)
                {
                   total++;
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();


            int[] evenArray = new int[5] { 2, 4, 5, 6, 7 };
            List<int> newArray = new List<int>();
            
            for(int i =  0; i < evenArray.Length; i++)
            {
                
                if(i % 2 == 0)
                {
                    newArray.Add(i);
                }
            }

            newArray.ToArray();
            int total2 = newArray.Sum();
            Console.WriteLine(total2);
            Console.ReadLine();

            string ExampleString = "Hello";
            ExampleString = new string(ExampleString.ToCharArray().Reverse().ToArray());
            Console.WriteLine(ExampleString);
            Console.ReadLine();


            var Dupstring = "wwwhhhaaaaaaaattttt";
            var noDup = "";
            var set = new HashSet<char>();
            
            foreach( var letter in Dupstring)
            {
                if (set.Add(letter))
                {
                    noDup += letter;
                }
            }

            Console.WriteLine(noDup);
            Console.ReadLine();


            for ( int i = 0; i < 101; i++)
            {
                if( i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.ReadLine();

                }
                else if( i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.ReadLine();
                } else
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
        }
    }
}
