using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public  class MathStuff
    {
        int userNumber { get; set; }

        public int addNumber(int userNumber)
        {
            int answer = userNumber + 2;
            return answer;
        }

        public int subtractNumber(int userNumber)
        {
             int answer =userNumber - 2;
            return answer;
        }

        public  int divideNumber(int userNumber)
        {
            int answer = userNumber / 2;
            return answer;
        }
    }
}
