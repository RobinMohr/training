﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele plätze soll die Liste haben?");
            int i =Convert.ToInt32(Console.ReadLine());

            int[] zahlen = new int[i];
            Console.WriteLine("Gebe nun "+i+" zahlen ein:");

            for (int j = 0; j < i; j++)
            {
                zahlen[j] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (double j in zahlen)
            {
                Console.WriteLine(j);
            }

            double x = 0;
            foreach (double j in zahlen)
            {
                 x = x + j;
            }
            
            double max = zahlen.Max();
            double min = zahlen.Min();
            double avg = zahlen.Average();

            Console.WriteLine("max:" + max);
            Console.WriteLine("min:" + min);
            Console.WriteLine($"summe:{x}");
            Console.WriteLine($"average:{x}");


            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Wie viele zeilen soll die liste haben?");
            int p = Convert.ToInt32(Console.ReadLine());

            string[] text = new string[p];

            for (int l = 0; l < p; l++)
            {
                text[l] = Console.ReadLine();
            }
            foreach (string s in text)
            {
                Console.WriteLine(s.Replace(' ', ';'));
            }



            Console.ReadLine();
        }
    }
}



































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































