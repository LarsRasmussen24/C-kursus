using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_stuff
{
    class Program
    {
        static void Main(string[] args)
        {


            FilTyper ft = FilTyper.csv;

            Console.WriteLine(ft);
            Console.WriteLine((int)ft);


            Person p;

            p.id = 1;
            p.Navn = "Bent";

            Console.WriteLine(p.Navn);






            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }



    public struct Person
    {

        public int id;
        public string Navn;
               
    }





    public enum FilTyper 
    {
        csv,
        pdf,
        txt
    }


}
