using Examen2JhoyInga.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2JhoyInga.Clases
{
    public class GerenteRRHH : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override int SueldoBase => 8000;

        public decimal CalcularBonificacion()
        {
            decimal bonificacion = 1000;

            return bonificacion;
        }

        public decimal DescontarSueldo()
        {
            return SueldoBase * Constantes.porcentDstoGerenteRH;

        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }

    }
}
