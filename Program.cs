using Examen2JhoyInga.Clases;
using Examen2JhoyInga.Interfaces;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente
{
    IdEmpleado = 1,
    Nombre = "Hugo Torrico",
    Puesto = "Gerente Desarrollo"
};

Desarollador desarollador = new Desarollador
{
    IdEmpleado = 2,
    Nombre = "José Cárdenas",
    Puesto = "Desarrollador Senior",
};

GerenteRRHH gerenteRRHH = new GerenteRRHH
{
    IdEmpleado = 3,
    Nombre = "Marco Gutierrez",
    Puesto = "Gerente de RRHH",
};

ConsultorExterno consultorExterno = new ConsultorExterno
{
    IdEmpleado = 4,
    Nombre = "Jhoy Inga",
    Puesto = "Consultor Externo",
};



empleados.Add(gerente);
empleados.Add(desarollador);
empleados.Add(gerenteRRHH);
empleados.Add(consultorExterno);


foreach (var empleado in empleados)
{
    empleado.CalcularSueldo();
    empleado.MostrarDetalle();
    
    decimal sueldo = empleado.CalcularSueldo();

    if (empleado is ISueldoBonificable empleadoBonificable)
    {
        empleadoBonificable.CalcularBonificacion();
    }
    if (empleado is IDescuentoImpuesto empleadoDescuento)
    {
        empleadoDescuento.DescontarSueldo();
    }

}

/*
void MostrarMenu()
{
    int opcion;
    string opcion2;

    do
    {
        Console.WriteLine("Ingresa una de las siguientes opciones:");
        Console.WriteLine("1) Ingresar Empleado.");
        Console.WriteLine("2) Mostrar Listado de Empleado.");
        Console.WriteLine("3) Salir");
        opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese el tipo de empleado:");
                Console.WriteLine("A) Gerente");
                Console.WriteLine("B) Gerente de RRHH");
                Console.WriteLine("C) Desarrollador");
                Console.WriteLine("D) Consultor Externo");
                opcion2 = Console.ReadLine();
      
                break;

            case 2:
                Console.WriteLine("Ingrese un numero de dia de la semana:");
                break;

            default:
                break;
        }

        Console.WriteLine("==============================");
        Console.WriteLine("==============================");

    } while (opcion != 3);

}

MostrarMenu();

*/
Console.Read();