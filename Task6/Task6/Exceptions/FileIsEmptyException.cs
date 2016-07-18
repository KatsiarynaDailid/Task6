using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Exceptions
{
    public class FileIsEmptyException : Exception
    {
        public FileIsEmptyException() { } 

        public FileIsEmptyException(string message) : base(message) { }

        public override string Message
        {
            get
            {
                return string.Format("You are trying to download information from empty file. Try to enter another path to file with information.");
            }
        }

    }
}
