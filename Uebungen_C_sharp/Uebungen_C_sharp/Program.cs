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
            Console.WriteLine("Bitte gib die erste Zahl ein:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number = number1 + number2;

            Console.WriteLine(number);


            Console.ReadLine();
        }
    }
}
