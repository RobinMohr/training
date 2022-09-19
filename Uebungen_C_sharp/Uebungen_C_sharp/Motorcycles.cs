using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Lion :Animals
    {
        public Lion(bool furr, int age, double height, int life_span, int weight, int hunger)
        {
            Furr = furr;
            Age = age;
            Height = height;
            Life_Span = life_span;
            Weight = weight;
            Hunger = hunger;
        }
        public Lion()
        {
            Furr = true;
            Age = 4;
            Height = 1.2;
            Life_Span = 14;
            Weight = 190;
            Hunger = 50;
        }
        public void Eating()
        {

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
