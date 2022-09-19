using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Vehicle
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }
        public Vehicle()
        {



        }
        public Vehicle(int typeId, string make, string model, string typeName, int cCM, string color, int tyres)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            CCM = cCM;
            Color = color;
            Tyres = tyres;
        }



        public void PrintVehicleInformation()
        {
            Console.WriteLine($"Mein Fahrzeug ist ein " +
                $"{Make} {Model} {TypeName} mit einem Hubraum von " +
                $"{CCM} in der Farbe {Color} mit {Tyres} Reifen");
        }



        public static Vehicle AskUserForVehicle()
        {
            Vehicle c = new Vehicle();
            Console.WriteLine("Wie heißt die Marke?");
            c.Make = Console.ReadLine();
            Console.WriteLine("Gebe mri den Modelnamen");
            c.Model = Console.ReadLine();
            Console.WriteLine("Wie ist der Typ Name?");
            c.TypeName = Console.ReadLine();
            Console.WriteLine("TypeId?");
            c.TypeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Farbe?");
            c.Color = Console.ReadLine();
            Console.WriteLine("Anzahl Reifen?");
            c.Tyres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hubraum");
            c.CCM = Convert.ToInt32(Console.ReadLine());
            return c;
        }

        public bool MotorLaeuft { get; private set; }
        public int Geschwindigkeit { get; private set; }


        public void Starten()
        {
            if (MotorLaeuft == true)
            {
                Console.WriteLine("Motor läuft bereits");
            }
            else
            {
                MotorLaeuft = true;
                Console.WriteLine("Motor wird gestartet!.... WRRRUUUUUUUMMMM");
            }

        }
        public void beschleunigen()
        {
            Geschwindigkeit += 10;
        }

        public void bremsen()
        {
            if (Geschwindigkeit <= 0)
            {
                Console.WriteLine($"{this.GetType().Name} steht bereits!");
            }
            else
            {
                Geschwindigkeit -= 10;
                Console.WriteLine($"{this.GetType().Name} wird gebremst");
            }



        }

    }
}
