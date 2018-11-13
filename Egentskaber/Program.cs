using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egentskaber
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p = new Person();
            p.Fornavn = "Lars";
            p.Efternavn = "Overvad";


            Console.WriteLine(p.FuldtNavn());

            string value = Console.ReadLine();


        }


        class Person
        {

            public string Fornavn { get; set; }

            private string _efternavn;

            public string Efternavn
            {
                get
                {

                    return _efternavn;
                }
                set
                {
                    if (value.Length < 3)
                    {
                        _efternavn = "";
                    }
                    else
                    {
                        _efternavn = value;

                    }
                }
            }


            public string FuldtNavn()
            {

                return Fornavn + " " + Efternavn;


            }





        }

    }
}
