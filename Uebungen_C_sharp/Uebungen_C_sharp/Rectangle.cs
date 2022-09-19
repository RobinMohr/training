using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Rectangle :IGeometry
    {
        public Rectangle(float seite1, float seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }

        public float Seite1 { get; set; }
        public float Seite2 { get; set; }


        public float Flaeche()
        {
            return Seite1 * Seite2;
        }

        public float Umfang()
        {
            return 2*(Seite1 + Seite2); 
        }
    }
}
