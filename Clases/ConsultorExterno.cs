﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2JhoyInga.Clases
{
    public class ConsultorExterno : EmpleadoBase
    {
        public override int SueldoBase => 5000;

        public override decimal CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
