using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    internal class House
    {
        public House(double length_House, double width_House, double height, string roof_Type, string color, int amount_Floors, double price, double length_Property, double width_Property)
        {
            Length_House = length_House;
            Width_House = width_House;
            Height = height;
            Roof_Type = roof_Type;
            Color = color;
            Amount_Floors = amount_Floors;
            Price = price;
            Length_Property = length_Property;
            Width_Property = width_Property;
        }

        public double Length_House {  get; set; }
        public double Width_House { get; set; }
        public double Height { get; set; }
        public string Roof_Type { get; set; }
        public string Color { get; set; }
        public int Amount_Floors { get; set; }
        public double Price { get; set; }
        public double Length_Property { get; set; }
        public double Width_Property { get; set; }

        
        public static House UserInformation()
        {
            Console.Clear();
            
            Console.WriteLine("Wie lang ist dein Haus?");
            double house_length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie breit ist dein Haus?");
            double house_width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie hoch ist dein Haus?");
            double house_height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welche Art von Dach hast du?");
            string roof_type = Console.ReadLine();

            Console.WriteLine("Welche Farbe hat dein Haus?");
            string color = Console.ReadLine();

            Console.WriteLine("Wie viele Stockwerke hat dein Haus?");
            int floors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie viel kostet das Haus?");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie lang ist dein Grundstück?");
            double property_length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie breit ist dein Grundstück?");
            double property_width = Convert.ToDouble(Console.ReadLine());
            House house = new House(house_length, house_width, house_height, roof_type, color, floors, price, property_length, property_width);

            double qm_property = property_length * property_width;
            double living_space = floors * house_width * house_length;
            double walls = house_length * house_height * 4;

            return house;

        }

        public void House_Information()
        {
            double qm_property = Length_Property * Width_Property;
            double living_space = Amount_Floors * Width_House * Length_House;
            double walls = Length_House * Height * 4;

            Console.WriteLine("");
            Console.WriteLine($"Dein Haus ist {Length_House}m lang, {Width_House}m breit und {Height}m hoch." +
                $"Es hat ein {Roof_Type}-Dach, die Farbe {Color} und hat {Amount_Floors} Etagen." +
                $"Das Haus kostet {Price}€, und das Grundstück hat eine länge von {Length_Property}m und eine Breite von {Width_Property}m.");
            Console.WriteLine("");
            Console.WriteLine($"Dein Grundstück hat eine Fläche von {qm_property}qm." +
                $"Das Haus hat eine bewohnbare Fläche von {living_space}qm " +
                $"Wenn du die Wände anders Steichen wollen würdest, bräuchtest du genug Farbe umd {walls}qm fläche zu bedecken.");
        }

        public void Color_Change(string neueFarbe)
        {
            
            this.Color = neueFarbe;
        }





    }
}
