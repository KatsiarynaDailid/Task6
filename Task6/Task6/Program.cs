using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            OperationsWithFile file = new OperationsWithFile();
            file.GetListWithFirstLetters();
            ConsoleReaderWriter rw = new ConsoleReaderWriter();
            rw.WriteResult(file);
            Logic logic = new Logic();
            logic.GetExceptionForEmptyLines(file);
       
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();


        }
    }
}
