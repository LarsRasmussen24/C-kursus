using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning T = new Terning();
            T.Værdi = 5;
            T.Skriv();
            T.ryst();
            T.Skriv();

            T = new Terning(2);
            T.Skriv();




            string value = Console.ReadLine();

        }


        public class Terning
        {


            private int _værdi;

            public int Værdi
            {
                get
                {
                    Console.WriteLine("Terningen viser: " + _værdi);
                    return _værdi;
                }

                set
                {
                    if (value < 1 || value > 6)
                    {
                        value = 1;
                    }
                    Console.WriteLine("Terningen tildeles: " + value);
                    _værdi = value;
                }
            }


            private static System.Random rnd = new System.Random();


            public void Skriv()
            {
                Console.WriteLine("Terningen viser: " + this._værdi);
            }

            public void ryst()
            {
                this._værdi = rnd.Next(1, 7);
            }

            public Terning()
            {
            }

            public Terning(int værdi)
            {
                this._værdi = værdi;
            }



        }



    }


}
