using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter
{
    class Program
    {
        static void Main(string[] args)
        {

            int H = 11;
            int G = 22;

            Trekant t = new Trekant(H, G);

            Console.WriteLine("højde = " + t.Højde);
            Console.WriteLine("grundlinie = " + t.Grundlinie);
            Console.WriteLine("areal = " + t.Areal);



            string value = Console.ReadLine();

        }


        class Trekant
        {

            public int Grundlinie { get; private set; }
            public int Højde { get; private set; }


            public Trekant(int _grundlinie, int _højde)
            {
                this.Grundlinie = _grundlinie;
                this.Højde = _højde;
            }

            public double Areal
            {
                get
                {
                    return this.Grundlinie * this.Højde * 0.5;
                }

            }
        }
    }
}
