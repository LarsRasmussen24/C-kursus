using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{


    //public delegate void MinDelegate1(string txt);  //Skal stå på namespace niveau



    class Program
    {
        static void Main(string[] args)
        {
            //      MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);

            MinSkrivTilConsole("xxx");

            Action<string> f1 = MinSkrivTilConsole;
            f1("zzz");



            //MinDelegate1 f3 = new MinDelegate1(MinSkrivTilConsole);
            //f3("kkk");
            //f3 += Console.WriteLine;
            //f3("kkk");






            Console.ReadLine();
        }


        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }


    }


}
