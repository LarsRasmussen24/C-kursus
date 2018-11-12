using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));

            Console.WriteLine(Beregn(2, 4, 6));



            Console.WriteLine(Beregn(1, 2, 3));








            string value = Console.ReadLine();

        }


        public static int Beregn(int a, int b)
        {

            return a + b;


        }


        public static int Beregn(int a, int b, int c)

        {
            return a + b + c;

        }



    }

}