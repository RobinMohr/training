using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crocodile c = new Crocodile(false, 12, 4.3, 70, 450, 50);
            Lion l = new Lion(true, 4, 1.2, 14, 190, 50);
            Elephant e = new Elephant(false, 12, 2.8, 50, 5000, 50);
            bool spiel = true;
            int animal_count = 3;

            List<Animals> animals = new List<Animals>();
            animals.Add(c);
            animals.Add(l);
            animals.Add(e);

            do
            {
                foreach (Animals animal in animals)
                {
                    animal.Eating(animal_count, animals);
                }



            } while (spiel);

            Console.ReadKey();
        }

    }
}



































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































