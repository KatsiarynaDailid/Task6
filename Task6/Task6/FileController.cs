using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Exceptions;


//Задание 1
//Напишите консольное приложение, которое получает от пользователя с консоли путь к файлу и затем выводит на 
//    экран первый из символов каждой строки.Пустая строка в файле считается некорректными данными, то есть ошибкой.
//    При этом должны быть обработаны все строки в файле.Обо всех ошибках(пустые строки, отсутствие файла, и прочие) 
//    нужно выводить сообщение пользователю на консоль и детальное описание проблемы в лог.


namespace Task6
{
    class FileController
    {

        

        public string CheckTheExictingOfTheFile()
        {
          ConsoleReaderWriter consRead = new ConsoleReaderWriter();

            string path = consRead.GetFilePathFromConsole();

            if (!File.Exists(path))
                throw new FileIsNotExistException();
            else if (new FileInfo(path).Length == 0)
                throw new FileIsEmptyException();

            return path;

        }

    }
}
