using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please provide a number: ");
                int answer = Convert.ToInt32(Console.ReadLine());
                
            try
            {
                DaysofWeek daysOf = (DaysofWeek)answer;
                
            }catch(daysOf == 1){

            }    

            }
            }
        }

        enum DaysofWeek
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
    }
}
