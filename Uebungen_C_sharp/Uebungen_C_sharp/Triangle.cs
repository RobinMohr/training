using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Triangle :IGeometry
    {
        public Triangle(float seite1, float seite2, float seite3)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }

        public float Seite1 { get; set; }
        public float Seite2 { get; set; }
        //Hypothenuse
        public float Seite3 { get; set; }

        public float Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }

        public float Flaeche()
        {
            return (Seite1 * Seite2) /2;
        }

    }
}
