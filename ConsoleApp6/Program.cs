using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p1 = new Person();
            Elev e1 = new Elev();




            p1.Fornavn = "Lars";
            p1.Efternavn = "Overvad";


            e1.Fornavn = "Jonas";
            e1.Efternavn = "Overvad";
            e1.Klaselokale = 33;

            Instruktør i1 = new Instruktør();
            i1.Efternavn = "Hansen";
            i1.NøgleID = 123;





            Console.WriteLine(e1.FuldtNavn());
            Console.WriteLine("er i lokale " + e1.Klaselokale);


            Console.WriteLine($"Instruktøren er {i1.Efternavn}");
            Console.WriteLine(p1.FuldtNavn());


            UdvidetRandom RandBool = new UdvidetRandom();   //laver en instans af UdviddetRandom, som jeg selv har lavet, og som arver fra Random

            Console.WriteLine($"tilfældig Bool: {RandBool.NextBool()}");












            Console.ReadLine();



        }

    }


    public class Person

    {

        public String Fornavn { get; set; }


        public String Efternavn { get; set; }


        public String FuldtNavn()
        {
            String FN = $"{this.Fornavn} {this.Efternavn}";
            return FN;
        }

    }


    public class Elev : Person

    {
        public int Klaselokale { get; set; }
    }



    public class Instruktør : Person

    {
        public int NøgleID { get; set; }
    }



    public class UdvidetRandom : System.Random

    {
        public bool NextBool()
        {
            int tal = this.Next(1, 11);

            bool svar = false;


            if (tal > 5)
            {
                svar = true;
            }




            return svar;

        }
    }
}


