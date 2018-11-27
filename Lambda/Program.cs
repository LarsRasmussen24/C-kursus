using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a1 = new List<int> { 5, 8, 9, 3, 51, 5, 1, 2 };


            for (int i = 0; i < 7; i++)
            {
                if (Find(a1[i], 51))
                {
                    Console.WriteLine(a1[i]);
                }

            }


            Console.WriteLine(Find(3, 51));


            Predicate<int> a2 = (x) => x == 51;

            //mangler lige at bruge a2 metoden..



            Console.ReadLine();






        }

        public static bool Find(int a, int b)
        {
            return a == b;
        }


    }
}
