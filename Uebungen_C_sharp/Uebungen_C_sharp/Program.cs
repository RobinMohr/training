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
            //string zahl = Convert.ToInt32(Console.ReadLine());

            //switch (zahl)
            //{
            //    case "1":
            //        Console.WriteLine("Die Zahl ist 1");
            //        break;
            //    case "2":
            //        Console.WriteLine("Die zahl ist 2");
            //        break;
            //    case "5":
            //        Console.WriteLine("Die zahl ist 5");
            //        break;
            //    default:
            //        Console.WriteLine("Kein Fall tritt ein");
            //        break;
            //}

            Console.WriteLine("erste zahl:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("zweite zahl:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Was soll mit den Zahlen gemacht werden?");
            Console.WriteLine("+ zum addieren; - zum subtrahieren");
            Console.WriteLine("* zum multiplizieren; / zum teilen");
            Console.WriteLine("avg um den durchschnitt zu berechnen");
            string befehl = Console.ReadLine();

            double sum = 0;

            switch (befehl)
            {
                case "+":
                    sum = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + sum);
                    break;

                case "-":
                    sum = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + sum);
                    break;

                case "/":
                    sum = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + " = " + sum);
                    break;

                case "*":
                    sum = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + sum);
                    break;

                case "avg":
                    sum = num1 + num2;
                    double avg = sum / 2;
                    Console.WriteLine("(" + num1 + " + " + num2 + ")" + " / 2" + " = " + avg);
                    break;
                default:
                    Console.WriteLine("Du hast nicht valides eingegeben.");
                    return;



            }






            Console.ReadLine();
        }
    }
}
