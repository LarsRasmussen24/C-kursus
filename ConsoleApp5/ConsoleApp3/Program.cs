using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool FileExist;


            Console.WriteLine("kører her");


            string sti = "c:\\temp\\tal.txt";

            
            if (!System.IO.File.Exists(sti))
                throw new ApplicationException("Filen existerer ikke: " + sti);


            string indhold = "";
            try

            {
                indhold = System.IO.File.ReadAllText(sti);

                int intIndhold = Convert.ToInt32(indhold);
                                          
            }


            catch (System.FormatException ex)
            {
                FormatException e = new FormatException("Indhold kan ikke konverteres til Heltal" + ex);
                throw e;



            }


            catch (Exception)
            {

                
                throw;

            }






            string value = Console.ReadLine();



        }
    }
}
