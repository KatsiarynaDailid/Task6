using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Task6.Exceptions;

namespace Task6
{
    class OperationsWithFile
    {

        public string FilePath { get; set; }
        public List<char> listForPrinting { get; set; }
        public List<int> listForEmptyLines { get; set; }
        public List<string> listForChecking { get; set; }


        public OperationsWithFile()
        {
            Logic log = new Logic();     
            string filePath = log.GetCorrectFilePath();
            this.FilePath = filePath;
            listForChecking = new List<string>();
            listForPrinting = new List<char>();
            listForEmptyLines = new List<int>();

        }


        public void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                String str = reader.ReadLine();
                while (str != null)
                {
                     
                    listForChecking.Add(str);
                    str = reader.ReadLine();
                }          
            }
        }

        public void GetListWithFirstLetters()
        {

            ReadFromFile();

            listForPrinting = listForChecking
                .Where(s => s.Length > 0)
                .ToList()
                .Select(s => s.ToCharArray()[0])
                .ToList();
        }

        public void GetListWithEmptyStrings()
        {         
            listForEmptyLines = listForChecking
                .Select((elem, index) => new { Elem = elem, Index = index })
                .ToList()
                .Where(s => s.Elem.Length == 0)
                .Select(s => s.Index + 1)
                .ToList();


            if (listForEmptyLines.Count != 0)
                throw new FileHasAnEmptyLinesException(listForEmptyLines);

        }

    }
}
