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
            string valiuta = Console.ReadLine();
            Console.WriteLine("Iveskite EUR kieki:");
            double keiciamaSuma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jums priklauso: {0} {1}", Keisti(valiuta, keiciamaSuma), valiuta);
            Console.ReadLine();



        }
        public static double Keisti (string valiuta, double keiciamaSuma)
        {
            double result= 0;
            if (valiuta == "USD")
            {
                result = 1.1 * keiciamaSuma;          
            }
            if (valiuta == "PLN")
            {
                result = 4.3 * keiciamaSuma;
            }
            return result;
        }
    }
}
