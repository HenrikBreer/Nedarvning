using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            t1.Skriv();
            Console.WriteLine();
            Console.ReadKey();

            LudoTerning t2 = new LudoTerning();
            t2.Skriv();
            Console.WriteLine();
            Console.ReadKey();


        }
    }

    class Terning
    {
        private int værdi;

        private static Random rnd = new Random();
        public int Værdi
        {
            get { return værdi; }
            set
            {
                if (value < 1 || value > 6)
                {
                    value = 1;
                }

                værdi = value; }
        }

        public int Ryst()
        {
            return rnd.Next(1, 6);
        }
        
        public virtual void Skriv()
        {
            Console.WriteLine("["+Værdi+"]");
        }

        public Terning()
        {
           Værdi =  Ryst();
        }

        public Terning(int i)
        {
            Værdi = i;
        }


    }

    class LudoTerning : Terning
    {
        public bool erGlobus()
        {
            if (Værdi == 3) { return true; } else { return false; }
        }

        public bool erStjerne()
        {
            if (Værdi == 5) { return true; } else { return false; }
        }

        public LudoTerning() : base() { }
        public LudoTerning(int i) : base(i) { }

        public override void Skriv()
        {
            string tekst = "";
            if (erGlobus()) { tekst = "[G]"; }
            else if (erStjerne()) { tekst = "[S]"; }
            else { tekst = "[" + Værdi + "]"; }


            Console.WriteLine(tekst);
        }

    }


    }
