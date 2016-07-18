using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.Exceptions;

namespace Parser
{
   public  class Cage
    {

        public void ParseIntCorrectly(String s, out int result)
        {
            Logic type = new Logic();
            result = 0;
            try
            {
               result = type.DetermineType(s);
            }
            catch(NumberIsOutOfIntegerException ex)
            {             
                Console.WriteLine(ex.Message);
            }
            catch(ItIsAFloatNumberException ex)
            {
      
                Console.WriteLine(ex.Message);
            }
            catch(ItIsAStringException ex)
            {
          
                Console.WriteLine(ex.Message);
            }

        
        }

    }
}
