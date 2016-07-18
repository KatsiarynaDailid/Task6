using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Exceptions
{
    class FileHasAnEmptyLinesException : Exception
    {

        private List<int> indOfExceptions;  


        public FileHasAnEmptyLinesException(List<int> indexes) {

            this.indOfExceptions = indexes;
        }

        public FileHasAnEmptyLinesException(string message) : base(message) { }

        public override string Message
        {
            get
            {
                String res = "";
                foreach (var ind in indOfExceptions) {
                    res += (ind + ", ");
                }

                return string.Format($"You have an empty strings in your file. The indexes: {res}");
            }
        }
    }
}
