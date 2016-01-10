using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class InvalidPassword : Exception
    {
         public InvalidPassword (string message)
            :base (message)
        {

        }
    }
}
