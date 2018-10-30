using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string forNavn = "Mikkkel";
            string efterNavn = "Cronberg";
            string SamletNavn = forNavn + " " + efterNavn;

            string navnStort = SamletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = SamletNavn.ToLower();
            Console.WriteLine(navnLille);

            

            string del = SamletNavn.Substring(5,2);
            Console.WriteLine(del);

                        
            int delStart = SamletNavn.IndexOf(" ");
            

            string del2 = SamletNavn.Substring(delStart+1, 4);
            Console.WriteLine(del2);



            Console.WriteLine("asdasdfa sdf \r\n afd adslkjadsf");


            System.IO.File.WriteAllText("c:\\temp\\LSR.txt",del2);










            Console.ReadLine();




        }
    }
}
