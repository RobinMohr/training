using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public abstract class Animals
    {
        public bool Furr  { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public int Life_Span { get; set; }
        public int Weight { get; set; }
        public int Hunger { get; set; }

        public abstract void Eating();
            

        public void Eating(int animal_count, List<Animals> animals)
        {
            int food_count = 0;
            if (animal_count == 3)
            {
                food_count = 20;
            }
            else if (animal_count == 2)
            {
                food_count = 15;
            }
            else if (animal_count == 1)
            {
                food_count = 7;
            }
            Console.WriteLine($"Du hast {animal_count} Tiere und {food_count} Rationen.");

            Console.WriteLine("Wie viel möchtest du das Krokodil füttern?");


        }










    }
}
