using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinDict
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Console.WriteLine("Välkommen till ordlistan!");
            Console.WriteLine("Skriv 'sluta' för att sluta!");
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                Console.WriteLine("Läst kommando: {0}", command);
            } while (command != "sluta");
        }
    }
}
