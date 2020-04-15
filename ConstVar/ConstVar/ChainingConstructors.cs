using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class ChainingConstructors
    {
        public string firstName;
        public string lastName;
        public int favoriteNumber;

        public Individual(string FirstName)
        {
            firstName = FirstName;
        }
    }
}
