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
            

            //von bestimmter zahl runterzählen
            int j = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; j > i; j--)
            {
                Console.WriteLine(j);
            } 
            

            //
            Console.WriteLine("gib einen buchstaben ein nachdem du suchen willst");
            string input = Console.ReadLine();


            var namen = new List<string> { "Hannes", "Marcello", "Robert", "Erwin", "Jonas", "Robin"};
            foreach (var element in namen)
            {
                if (element.Contains(input))
                {
                    Console.Write($"{element} ");
                }
            }   
            

            Random random = new Random();
            int random_zahl = random.Next(0, 100);
            
            while (true){
                Console.WriteLine("Rate eine Zahl zwischen 0 und 100");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess == random_zahl)
                {
                    Console.WriteLine("Du hast gewonnen!");
                    break;
                }
                else if(guess < random_zahl)
                {
                    Console.WriteLine("Die zufällige Zahl ist größer.");
                }
                else if(guess > random_zahl)
                {
                    Console.WriteLine("Die zufällige Zahl ist kleiner.");
                }
            }
            Console.WriteLine("Willst du nochmal spielen?");
            string again = Console.ReadLine();

            Random random1 = new Random();
            int random_zahl1 = random1.Next(0, 100);

            if (again.Contains("j")){

                Console.WriteLine("Rate eine Zahl zwischen 0 und 100");
                int guess1 = 0;
                do
                {

                    int guess1 = Convert.ToInt32(Console.ReadLine());

                    if (guess1 == random_zahl1)
                    {
                        Console.WriteLine("Du hast gewonnen!");
                        break;
                    }
                    else if (guess1 < random_zahl1)
                    {
                        Console.WriteLine("Die zufällige Zahl ist größer.");
                    }
                    else if (guess1 > random_zahl1)
                    {
                        Console.WriteLine("Die zufällige Zahl ist kleiner.");
                    }
                } while (guess1 != random_zahl1);
            }
            

            int[] zahlen = new int[5];

            for(int i = 0; i< zahlen.Length; i++)
            {
                Console.WriteLine("gebe mir eine Zahl für das Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }


            for(int i = 0; i< zahlen.Length; i++)
            {
                Console.WriteLine($"|  {zahlen[i]}  |");
            }
            

            string[] namen = new string[13];
            string[] namen2 = new string[] 
            {
                "Lukas", "Jonas", "Mona", "Marie", 
                "Phillip", "Jan", "Erwin", "Leon", 
                "Marcello", "Johannes", "Robin", 
                "Andreas", "Robert"
            };

            foreach(string trainee in namen2)
            {
                Console.WriteLine(trainee);  
            }

            for(int i = 0; i< namen2.Length; i++)
            {
                namen2[i] += " 231";
                Console.WriteLine(namen2[i]);
            }
            */

            //array (aufgabe 4)

            Console.WriteLine("Wie viele Zahlen soll die tabelle haben?");
            int i = Convert.ToInt32(Console.ReadLine());

            int[] zahlen = new int[i];

            int t = 1;

            for (int j = 0; j < i; j++)
            { 
                Console.WriteLine("Bitte gebe nun die " + t + ". Zahl ein.");
                zahlen[j] = Convert.ToInt32(Console.ReadLine());
                t = t + 1;
            }
            Console.Clear();
            foreach(int oi in zahlen)
            {
                Console.WriteLine(oi);
            }

            int b = 1000000;
            for (int a = 0; a < i; a++)
            {
                if (zahlen[a] < b)
                {
                    b = zahlen[a];
                }
            }
            Console.WriteLine("minimum: " + b);


            int c = 0;
            for (int a = 0; a < i; a++)
            {
                if (zahlen[a] > c)
                {
                    c = zahlen[a];
                }
            }
            Console.WriteLine("maximum: " + c);


            int sum = 0;
            foreach(int l in zahlen)
            {
                sum = sum + l;
            }
            int average1 = sum / i;
            Console.WriteLine("Der Durchschnitt ist: " + average1);







            /*
            double min = zahlen.Min();
            Console.WriteLine("Der nniedrigste Wert ist " + min + ".");

            double max = zahlen.Max();
            Console.WriteLine("Der höchste Wert ist " + max + ".");

            double avg = zahlen.Average();
            Console.WriteLine("Der Durchschnittswert ist " + avg + ".");
            */









            Console.ReadLine();
        }
    }
}
