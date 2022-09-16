using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wie viele namen willst du eingeben?");
            int t = Convert.ToInt32(Console.ReadLine());

            List<string> names = new List<string>();

            Console.WriteLine("bitte gebe " + t + " namen ein.");
            for (int i = 0; i < t; i++)
            {
                names.Add(Console.ReadLine());
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(names[i]);
            }

            


            Console.ReadLine();
        }
    }
}
