using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {



            Mere(1, 10);







            string value = Console.ReadLine();





            static void Mere(int a, int b)
            {

                if (a == b)
                    return;


                a++;

                Console.WriteLine(a);

                Mere(a, b);


            }


        }

    }
}
