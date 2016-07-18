using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Exceptions
{
    public class NumberIsOutOfIntegerException : Exception
    {    
            public NumberIsOutOfIntegerException() { }

            public NumberIsOutOfIntegerException(string message) : base(message) { }

            public override string Message
            {
                get
                {
                    return string.Format("You entered wrong type of data. Expected: integer number; Actual: long number.");
                }
            }

        
    }
}
