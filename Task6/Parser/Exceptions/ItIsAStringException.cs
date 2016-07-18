using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Exceptions
{
    public class ItIsAStringException : Exception
    {
        public ItIsAStringException() { }

        public ItIsAStringException(string message) : base(message) { }

        public override string Message
        {
            get
            {
                return string.Format("You entered wrong type of data. Expected: integer number; Actual: string.");
            }
        }


    }
}
