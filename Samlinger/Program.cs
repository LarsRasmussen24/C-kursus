using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p1 = new Person() { Id = 1, Navn = "M" };
            Person p2 = new Person() { Id = 2, Navn = "Æ" };
            Person p3 = new Person() { Id = 3, Navn = "H" };



            List<Person> lst = new List<Person>();


            lst.Add(p1);
            lst.Add(p2);
            lst.Add(p3);


            foreach (var item in lst)
            {
                Console.WriteLine(item.Navn);
            }

                        
            Dictionary<int,Person> lst1 = new Dictionary<int,Person>();

            //lst2.add(1,)




            string value = Console.ReadLine();


        }

        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
        }


    }
}
