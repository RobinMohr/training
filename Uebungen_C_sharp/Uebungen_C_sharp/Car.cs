using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Elephant :Animals
    {
        public Elephant(bool furr, int age, double height, int life_span, int weight, int hunger)
        {
            Furr = furr;
            Age = age;
            Height = height;
            Life_Span = life_span;
            Weight = weight;
            Hunger = hunger;
        }
        public void Eating(int food)
        {
            if (food > 15)
            {
                Console.WriteLine("Löwen scheinst du besonders gern zu haben, dein löwe bekommt einen ganzen Büffel zu essen.");
                Hunger += food;
            }
            else if (food > 10)
            {
                Console.WriteLine("Dein Löwe hat soeben ein ");
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
