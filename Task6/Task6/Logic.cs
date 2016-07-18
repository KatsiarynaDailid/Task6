using System;
using Task6.Exceptions;



namespace Task6
{
    class Logic
    {

        public string GetCorrectFilePath()
        {

            FileController fileContr = new FileController();
            Logg log = new Logg();
            string path = "";
            bool correct = false;

            do
            {
                try
                {
                    path = fileContr.CheckTheExictingOfTheFile();
                    correct = true;
                }
                catch (FileIsEmptyException ex)
                {
                    Console.WriteLine(ex.Message + "\n You can get extra informations about error here: " + Data.LoggPath);
                    log.WriteInAFile("Error message: "+ex.Message +"\r\nError stack trace: "+ ex.StackTrace);
                    //write stack trace in logg
                }
                catch (FileIsNotExistException ex)
                {                  
                    Console.WriteLine(ex.Message + "\n You can get extra informations about error here: " + Data.LoggPath);
                    log.WriteInAFile("Error message: " + ex.Message + "\r\nError stack trace: " + ex.StackTrace);
                    //write stack trace in logg
                }

            } while (!correct);

            return path;
        }


        public void GetExceptionForEmptyLines(OperationsWithFile file)
        {
            Logg log = new Logg();
            try
            {
                file.GetListWithEmptyStrings();
            }
            catch (FileHasAnEmptyLinesException ex)
            {
                Console.WriteLine(ex.Message + "\n You can get extra informations about error here: " + Data.LoggPath);
                log.WriteInAFile("Error message: " + ex.Message + "\r\nError stack trace: " + ex.StackTrace);
                //write stack trace in logg
            }

        }


    }
    }
