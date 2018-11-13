using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            int sum = 0;


            System.Array.Sort(månedsløn);


            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum = sum + månedsløn[i];
                Console.WriteLine(månedsløn[i]);

            }

            double middel = sum / månedsløn.Length;

            Console.WriteLine($"Gennemsnit {middel.ToString("N2")} kr");
            Console.WriteLine($"Gennemsnit {middel:C2}");




            string txt = "3;5;22;1;10;5";
            string[] txtArray = txt.Split(';');
            int sumElement = 0;




            for (int i = 0; i < txtArray.Length; i++)
            {
                sumElement = Convert.ToInt32(txtArray[i]) + sumElement;

            }

            double middel1 = sumElement / txtArray.Length;

            Console.WriteLine("middelværdig af txt array: " + middel1);



            sumElement = 0;

            foreach (string Element in txtArray)
            {
                sumElement = sumElement + Convert.ToInt32(Element);
            }

            Console.WriteLine("..og med foreach: " + sumElement/txtArray.Length);

            


            string value = Console.ReadLine();







        }
    }
}
