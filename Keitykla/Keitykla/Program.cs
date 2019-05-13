using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keitykla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I ka noretumete konvertuoti:[1] USD, [2] PLN");
            string valiuta = "";
            Console.WriteLine("Iveskite EUR kieki:");
            decimal keiciamaSuma = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Jums priklauso: {0} {1}", Keisti(valiuta, keiciamaSuma), valiuta);



        }
        static void double Keisti (int valiuta, decimal keiciamaSuma)
        {

        }
    }
}
