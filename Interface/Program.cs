using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            IDbFunktioner[] array = new IDbFunktioner[4];   //Laver et array på 4 med dem der har fået IDbFunktioner.

            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();

            foreach (var item in array)
            {
                item.Gem();                                 //..kalder Gem metoden, så de kan gemmes. Dvs. helt vilkårlige klasser kan kaldes, så de fx alle sammen gemmer.
            }



            Console.ReadLine();
        }
    }


    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer hund");
        }



    }

    class Ubåd : IDbFunktioner
    {
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd");
        }

        public int Nummer { get; set; }
        public double Tubine { get; set; }
    }


    interface IDbFunktioner     //Definering af fællesfunktioner for alle der er i gruppen IDbFunktioner
    {
        void Gem();             //..disse skal alle have en metode der hedder Gem.

    }




}
