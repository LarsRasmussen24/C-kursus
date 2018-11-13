using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag4_sum
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.Navn = "æbler";
            v.Pris = 10;


            Console.WriteLine();
            Console.WriteLine(v.Navn);
            Console.WriteLine(v.PrisMedMoms(2.2));
            string value = Console.ReadLine();


        }

        public class Vare
        {


            private string navn;

            public string Navn
            {
                get
                {
                    Console.WriteLine("navn læses");
                    return navn;
                }
                set
                {

                    Console.WriteLine("navn sættes");

                    navn = value;
                }
            }


            private double pris;

            public double Pris
            {
                get
                {
                    Console.WriteLine("pris læses");
                    return pris;
                }
                set
                {
                    Console.WriteLine("pris sættes");
                    pris = value;
                }
            }


            public double PrisMedMoms(double Avance)
            {
                return this.Pris * 1.25 * Avance;

            }





        }


    }
}
