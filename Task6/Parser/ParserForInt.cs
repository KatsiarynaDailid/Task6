using System;
using System.Globalization;
using System.Text.RegularExpressions;


/*     Задание 2
            Напишите библиотеку классов, которая содержит метод преобразования строки в целое число. 
            Использовать стандартные методы int.Parse() и int.TryParse() запрещено. Предусмотрите корректную обработку
            ошибок и выдачу исключений.
            Результаты проверять с помощью тестов. Консольное приложение создавать не нужно.
*/

namespace Parser
{
    public class ParserForInt
    {
      

        public string ParseToInt(String str, out int intNumber)
        {
            intNumber = 0;
            long temporaryValue = 0;


            if (str == null || str == "")
            {
                return "-3";
            }


            if ((str[0] == '-' && str.Length >= 11) || (str.Length >= 10))
            {
                return "0";

            }
            if (DetermineInt(str))
            {              
                if (str[0] == '-' || str[0] == '+')
                {
                    for (int i = 1; i < str.Length; i++)
                    {
                        temporaryValue *= 10;
                        temporaryValue += str[i] - '0';
                    }
                    if (str[0] == '-')
                    {
                        temporaryValue = temporaryValue * (-1);
                    } else { temporaryValue = temporaryValue * (+1); }
                }
                else
                {
                    foreach (char c in str)
                    {
                        temporaryValue *= 10;
                        temporaryValue += c - '0';
                    }
                }
                if (temporaryValue < int.MaxValue && temporaryValue > int.MinValue)
                {
                    intNumber = (int)temporaryValue;
                    return "1"; // if it`s int
                }
                else
                {
                    return "0"; // 0 - if it`s number, but long
                }
            }
            else if (DetermineFloat(str))
            {
                return "-1"; // -1 - if it`s number, but float
            }
            else { return "-2"; } // -2 - if it`s string
   
        }


        public static Boolean DetermineFloat(String str)
        {
            String separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            var reg = new Regex(@"^[+|-]?[0-9]*(?:" + separator+"[0-9]*)?$");        
            return reg.IsMatch(str);
        }


        public static Boolean DetermineInt(String str)
        {
            var reg = new Regex(@"^[+|-]?\d{1,10}$");
            return reg.IsMatch(str);
        }


    }
}
