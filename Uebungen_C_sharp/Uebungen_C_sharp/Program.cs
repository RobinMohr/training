using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zwei zahlen addieren
            Console.WriteLine("Bitte gib die erste Zahl ein:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int number = number1 + number2;

            Console.WriteLine(number);

            //im text u,U mit g,G ersetzen
            Console.WriteLine("Bitte gebe einen Text ein:");
            string entry = Console.ReadLine();

            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine("Du hast geschrieben: " + entry);
            Console.WriteLine("Ich habe daraus gemacht: " + replaced_entry);

            



            Console.ReadLine();
        }
    }
}
