using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("This will be a paragraph of four sentences equalling 4 lines \n This is the first line. \n This will be the second line. \n This is the third line. \n Finally this is the fourth.");
            Console.WriteLine(paragraph);
            Console.ReadLine();

            string String1 = "Hello";
            string String2 = "There";
            string String3 = "Friend";


            string wordsTogether = String1 + " " + String2 + " " + String3;

            Console.WriteLine(wordsTogether);
            Console.ReadLine();

            string UpperCase = "lowercase";
            Console.WriteLine(UpperCase.ToUpper());
            Console.ReadLine();

            

        }
    }
}
