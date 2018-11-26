using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortTestFW
{
    class Program
    {
        static void Main(string[] args)
        {
            KortspilApp.Kerne.Spillekort s = new KortspilApp.Kerne.Spillekort();

            Console.WriteLine(s.Farve + " " + s.Værdi);



            Console.ReadLine();


        }
    }
}
