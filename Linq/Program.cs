using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {


            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            foreach (var person in people)
                Console.WriteLine(person.Name);


            int Højde = 160;
            var res1 = people.Where(i => i.Height < Højde);

            Console.WriteLine();
            Console.WriteLine($"Der er findes kun {res1.Count()} personer under {Højde}cm ");

            Console.WriteLine("***************");

            var res2 = people.OrderBy(i => i.Name);

            foreach (var person in res2)
                Console.WriteLine(person.Name);

            Console.WriteLine("***************");


            var res3 = people.Where(i => i.Height < Højde).OrderBy(i => i.Name).ThenBy(i => i.Height);
            foreach (var person in res3)
                Console.WriteLine($"{person.Name} er under {Højde}cm. Højden er {person.Height}"); ;

            Console.WriteLine("%%%%%%%%%%%%%%");

            var res4 = from person in people where person.Height < Højde select person;             //samme kode med smartere syntax
            foreach (var person in res4)
                Console.WriteLine($"{person.Name} er under {Højde}cm. Højden er {person.Height}"); ;

            


            Console.ReadLine();



        }
    }
}
