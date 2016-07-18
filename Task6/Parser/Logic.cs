using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.Exceptions;

namespace Parser
{
   public class Logic
    {
        public int DetermineType(String s)
        {
            int result;
            ParserForInt parser = new ParserForInt();

            String resultStr = parser.ParseToInt(s, out result);

            switch (resultStr)
            {
                case "1":
                    return result;       
                case "0":  // 0 - if it`s number, but long
                    throw new NumberIsOutOfIntegerException();         
                case "-1": // -1 - if it`s number, but float
                    throw new ItIsAFloatNumberException();           
                case "-2": // -2 - if it`s string
                    throw new ItIsAStringException();
                case "-3":
                    throw new ArgumentNullException();       
            }

            return result;

        }

    }
}
