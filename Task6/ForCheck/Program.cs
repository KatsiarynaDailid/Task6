using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParserForInt pars = new ParserForInt();

            //String s = "12jkk3";
            //int n;

            //pars.ParseToInt(s,out n);

            Cage cage = new Cage();

            //int actual;
            //cage.ParseIntCorrectly("1254786", out actual);
            //int expected = 1254786;
            Logic logic = new Logic();

            int actual = logic.DetermineType("");

            //int actual;
            //            logic.ParseIntCorrectly("2147483648", out actual);
            //            long expected = 2147483648;


            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();


        }
    }
}
