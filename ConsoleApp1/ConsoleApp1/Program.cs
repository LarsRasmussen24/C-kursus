using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int c = lægsammen(33, 22);

            Console.WriteLine(c);


            double A = beregnAreal(10);

            Console.WriteLine(A);


            Console.ReadKey();

        }

        static int lægsammen(int a, int b)
        {

            return a + b;


        }


        static double beregnAreal(int r)

        {

            double Area = r * r* 3.14;


            return Area;


        }



    }
}
