﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen_C_sharp
{
    public class Motorcycles :Vehicle
    {
        public Motorcycles(int typeId, string make, string model, string typename, int ccm, string color, int tyres)
        {

            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typename;
            CCM = ccm;
            Color = color;
            Tyres = tyres;
            
        }

    }
}
