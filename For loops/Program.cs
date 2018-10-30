using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string resTab = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    int res = i * n;
                    string strRes = Convert.ToString(res).PadLeft(4);

                    if (res > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                    Console.Write(strRes + " ");

//                    resTab = resTab + " " + strRes;

                    
                }
    //resTab = resTab + "\n \r";


    Console.WriteLine();

            }

Console.WriteLine(resTab);

            string value = Console.ReadLine();

        }
    }
}
