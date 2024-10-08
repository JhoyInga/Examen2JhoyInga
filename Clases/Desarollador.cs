using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2JhoyInga.Clases
{
    public class Desarollador : EmpleadoBase
    {
        public override int SueldoBase => 3000;

        public override decimal CalcularSueldo()
        {
            return SueldoBase;
            /*throw new NotImplementedException();*/
        }
    }
}
