using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class InvalidE_mail : Exception
    {
        public InvalidE_mail (string message)
            :base (message)
        {

        }
    }
}
