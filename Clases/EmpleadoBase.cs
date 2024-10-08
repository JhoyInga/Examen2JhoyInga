using Examen2JhoyInga.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2JhoyInga.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public abstract int SueldoBase { get; }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }

        public string Puesto { get; set; }

        public abstract decimal CalcularSueldo();


        public void MostrarDetalle()
        {
            Console.WriteLine("IdEmpleado: " + IdEmpleado);
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Puesto: " + Puesto);
            Console.WriteLine("El sueldo base es: "+ SueldoBase);
            Console.WriteLine("El sueldo Neto es: " + CalcularSueldo());
            Console.WriteLine("");
        }
    }
}
