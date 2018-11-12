using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p1 = new Person("den", "helt anden", 1950);

            p1.Fornavn = "Ham";
            //p1.Efternavn = "Sæl";
            //p1.Fødselsår = 1966;


            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());


            Person p2 = new Person();

            p2.Fornavn = "Ham";
            p2.Efternavn = "Den Anden";
            p2.Fødselsår = 1956;

            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());



            string value = Console.ReadLine();
        }

    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;


        public Person()
        {
            this.Fornavn = "..";
            this.Efternavn = "..";
        }



        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";

        }

        public int Alder()
        {
            int iÅr = DateTime.Now.Year;
            int År = iÅr - Fødselsår;
            return År;
        }


        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fødselsår = Fødselsår;
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
        }


    }
}
