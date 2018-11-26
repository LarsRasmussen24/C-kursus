using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv___terning
{
    class Program
    {
        static void Main(string[] args)
        {


            Terning t1 = new Terning();



            t1.Værdi = 5;

            Console.WriteLine(t1.Værdi);



            LudoTerning t2 = new LudoTerning();
            t2.Værdi = 3;
            Console.WriteLine(t2.ErGlobus());


            LudoTerning t3 = new LudoTerning(3);
            Console.WriteLine(t3.ErGlobus());





            Console.ReadLine();


        }
    }


    public class Terning
    {

        private int værdi;


        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {

                if (value < 1 || value > 6)
                {
                    value = 1;
                }
                this.værdi = value;
            }
        }

        public Terning()
        { }
        public Terning(int værdi)
        { }

    }

    public class LudoTerning : Terning
    {

        public bool ErGlobus()
        {
            if (this.Værdi == 3)
            {
                return true;
            }
            return false;

        }

        public bool ErStjerne()
        {
            if (this.Værdi == 5)
            {
                return true;
            }
            return false;
        }


        public LudoTerning() : base()
        { }

        public LudoTerning(int værdi) : base(værdi)
        { }





    }


}



