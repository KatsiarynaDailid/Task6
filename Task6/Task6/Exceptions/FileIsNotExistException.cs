using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Exceptions
{
    class FileIsNotExistException : Exception
    {

        public FileIsNotExistException() { }

        public FileIsNotExistException(string message) : base(message) { }


        public override string Message
        {
            get
            {
                return string.Format("File with entered path doesn`t exists. Try to enter another path to existing file with information.");
            }
        }

    }
}
