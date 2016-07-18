using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ConsoleReaderWriter
    {

        public string GetFilePathFromConsole()
        {

            Console.WriteLine("Write file path: ");
            String path = Console.ReadLine();

            return path;

        }


        public void WriteResult(OperationsWithFile file)
        {
            Console.WriteLine("");
            foreach (var str in file.listForPrinting)
            {
                Console.WriteLine(str);
            }


        }


    }
}
