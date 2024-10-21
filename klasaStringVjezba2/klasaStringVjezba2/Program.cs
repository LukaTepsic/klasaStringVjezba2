using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string input = Console.ReadLine();
            string output = input.Replace(" ", "_");
            Console.WriteLine("Rezultat: " + output);
            Console.ReadKey();




        }
    }
}
