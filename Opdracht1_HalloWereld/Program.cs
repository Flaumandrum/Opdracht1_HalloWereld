using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1_HalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tom Adriaens 
             * 08/09/2022
             * Project : Hallo wereld
             */

            // Velden
            String _naam;

            // Programma 
            Console.WriteLine("Hallo wereld");
            Console.WriteLine();

            Console.Write("Geef uw naam: ");
            _naam = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hallo "+_naam);
            Console.WriteLine("Hallo {0}",_naam);
            Console.WriteLine($"{_naam}");
            

            Console.WriteLine("Druk op enter om af te sluiten.")

            Console.ReadKey();

        }
    }
}
