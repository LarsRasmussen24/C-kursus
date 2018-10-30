using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_stuff
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 20; i++)
            {


                  if (i%3 == 0)
                        if (i != 18)  Console.WriteLine(i);

            }


            string value = Console.ReadLine();

        }



    }

}
