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




            System.DateTime d1,d2,d3;
            System.TimeSpan dd;

            d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            d2 = new DateTime(2018, 5, 11);
            Console.WriteLine(d2);
            d3 = new DateTime(2019, 5, 11);
            Console.WriteLine(d3);


            dd = d3.Subtract(d1);
            Console.WriteLine(dd.Days);


            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);

            TimeSpan t4 = t3.Subtract(t2);
            Console.WriteLine(t4);

            TimeSpan t5 = t2.Add(t3);
            TimeSpan t5x = t2+t3;
            Console.WriteLine(t5);
            Console.WriteLine(t5x);










            Console.ReadLine();


        }
    }
}
