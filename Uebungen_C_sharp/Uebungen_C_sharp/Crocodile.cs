using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Crocodile : Animals
    {
        public Crocodile(bool furr, int age, double height, int life_span, int weight, int hunger)
        {
            Furr = furr;
            Age = age;
            Height = height;
            Life_Span = life_span;
            Weight = weight;
            Hunger = hunger;
        }

        public Crocodile()
        {
            Furr = false;
            Age = 12;
            Height = 4.3;
            Life_Span = 70;
            Weight = 450;
            Hunger = 50;
        }
        public void Eating(int food)
        {
            
            if (food > 15)
            {
                Console.WriteLine("Sieht so aus als wäre das Krokodil dein Lieblingstier, es freut sich sehr über das Nilpferd, welches du Ihm zu essen gegeben hast.");
                Hunger += food;
            }
            else if (food > 10)
            {
                Console.WriteLine("HMMMMMMM, Das Krokodil freut sich über die halbe Gazelle die es zu essen bekommen hat");
                Hunger += food;
            }

            else if (food >= 5)
            {
                Console.WriteLine("Nom Nom Nom, Dein Krokodil hat ein saftiges stück Fleisch gegessen.");
                Hunger += food;

            }
            else if (food > 0)
            {
                Console.WriteLine("Dein Krokodil hat ein altes stück Fleisch gegessen.");
                Hunger += food;

            }
            else if (food == 0)
            {
                Console.WriteLine("Dein Krokodil ist Traurig, weil es nichts zu essen bekommen hat.");
            }

        }
        public void Drinking()
        {

        }
        public void Dying()
        {

        }
        public void Being_Annoying()
        {

        }
        public void Getting_Born()
        {

        }

    }
}
