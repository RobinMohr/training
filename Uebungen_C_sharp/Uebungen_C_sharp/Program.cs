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
            /*
            //zwei zahlen addieren
            Console.WriteLine("Bitte gib die erste Zahl ein:");
            float number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte gib die zweite Zahl ein:");
            float number2 = Convert.ToInt32(Console.ReadLine());

            float number = number1 + number2;

            Console.WriteLine(number);
            
            //im text u,U mit g,G ersetzen
            Console.WriteLine("Bitte gebe einen Text ein:");
            string entry = Console.ReadLine();

            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine("Du hast geschrieben: " + entry);
            Console.WriteLine("Ich habe daraus gemacht: " + replaced_entry);
            

            //anzahl der wörter in einem text bestimmen
            Console.WriteLine("Bitte gebe einen weiteren Text ein:");
            string new_entry = Console.ReadLine();

            string[] entries = new_entry.Split(' ');

            int words = entries.Length;
            Console.WriteLine("Dein Text hat " + words + " Wörter."); 
            

            //Text von links bis zu 20 stellen mit y's auffüllen

            Console.WriteLine("Gebe bitte einen Text ein:");
            string text5 = Console.ReadLine();
            Console.WriteLine(text5.PadLeft(20, 'y'));
            

            //Text von rechts bis zu 30 stellen mit y's auffüllen
            Console.WriteLine("Gebe bitte einen Text ein:");
            string text6 = Console.ReadLine();
            Console.WriteLine(text6.PadRight(30, 'y'));
            

            //leerzeichen vor und nach dem text entfernen
            Console.WriteLine("Gebe bitte einen Text ein mit ein paar Leerzeichen vor und nach dem Text!");
            string text7 = Console.ReadLine();
            Console.WriteLine(text7.Trim());
            

            //splitting a text at a semicolon
            Console.WriteLine("Bitte gebe einen Text mit Semicolons ein!");
            string text99 = Console.ReadLine();

            string[] subs = text99.Split(';');

            foreach (var sub in subs)
            {
                Console.WriteLine(sub);
            }
           

            //wenn text abc beinhaltet dann true
            Console.WriteLine("Bitte gebe einen Text ein!");

            string text15 = Console.ReadLine();

            Console.WriteLine(text15.Contains("abc"));
            

            //ganzer text in caps
            Console.WriteLine("Bitte gebe einen Text ein!");
            string text87 = Console.ReadLine();

            Console.WriteLine(text87.ToUpper());
            

            //for schleife
            Console.WriteLine("gib eine Zahl ein:");

            int i = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int j = 0; i > sum; j ++)
            {
                sum = sum + j;
                Console.WriteLine(sum);
            }
            */

            //
            int j = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; j > i; j--)
            {
                Console.WriteLine(j);
            } 


            Console.ReadLine();
        }
    }
}
