using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    internal class Car
    {


        public int TypeId {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; } 
        public string Color { get; set; }
        public int Tyres { get; set; }


        public Car(int typeId, string make, string model, string typeName, int cCM, string color, int tyres)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            CCM = cCM;
            Color = color;
            Tyres = tyres;
        }

        public static Car UserInformation()
        {
            Console.Clear();

            Console.WriteLine("TypeId:");
            int TypeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Make:");
            string Make = Console.ReadLine();

            Console.WriteLine("Model:");
            string Model = Console.ReadLine();

            Console.WriteLine("TypeName:");
            string TypeName = Console.ReadLine();

            Console.WriteLine("CCM:");
            int CCM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Color:");
            string Color = Console.ReadLine();

            Console.WriteLine("Tyre amount:");
            int Tyres = Convert.ToInt32(Console.ReadLine());


            Car c1 = new Car(TypeId, Make, Model, TypeName, CCM, Color, Tyres);

            Console.ReadKey();

            return c1;

        }

        public void PrintCarInformation()
        {
            Console.WriteLine($"Mein Fahrzeug ist ein " +
                $"{Make} {Model} {TypeName} mit einem Hubraum " +
                $"{CCM} In der Farbe {Color} mit {Tyres} Reifen.");
        }

        
    }
}
