using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    class MDException : Exception
    {
        public MDException()
        {

        }
        public MDException(string message) : base(message)
        {

        }
    }
    class OutOfBaoundsException : MDException
    {
        public OutOfBaoundsException()
        {

        }
        public OutOfBaoundsException(string message) : base(message)
        {

        }
    }
}
