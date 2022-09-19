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
        public Elephant()
        {
            Furr = false;
            Age = 12;
            Height = 2.8;
            Life_Span = 50;
            Weight = 5000;
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
