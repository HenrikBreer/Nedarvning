using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person{Fornavn= "Henrik", Efternavn = "Breer" };
            Console.WriteLine(p1.Fuldtnavn());
            Elev e1 = new Elev { Fornavn ="Hans", Efternavn = "Jørgensen", Klasselokale= "2.1.345" };
            Console.WriteLine(e1.Fuldtnavn());

            string s = "";

            s = Console.ReadKey().KeyChar.ToString();

            Instruktør i1 = new Instruktør { Fornavn = "Hans", Efternavn = "Jørgensen", Nøgleid = 2 };
            Console.WriteLine(i1.Fuldtnavn());
            Console.WriteLine(i1.Nøgleid);
            s = Console.ReadLine().ToString();
            Console.WriteLine("fdABC");

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
    
    class Elev : Person
    {
        public string Klasselokale { get; set;  }
    }

    class Instruktør : Person
    {
        public int Nøgleid { get; set; }
    }

}
