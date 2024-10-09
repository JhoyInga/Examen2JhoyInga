using Examen2JhoyInga.Clases;
using Examen2JhoyInga.Interfaces;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

/*
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
*/

void ListarEmpleado()
{
    decimal sumaSueldos = 0;

    foreach (var empleado in empleados)
    {

        empleado.CalcularSueldo();
        empleado.MostrarDetalle();

        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            empleadoBonificable.CalcularBonificacion();
        }
        if (empleado is IDescuentoImpuesto empleadoDescuento)
        {
            empleadoDescuento.DescontarSueldo();
        }

        sumaSueldos = sumaSueldos + empleado.CalcularSueldo();
    }

    Console.WriteLine("Total de Empleados = " + empleados.Count);
    Console.WriteLine("Suma total de Sueldos al mes = "+sumaSueldos.ToString());
}


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
                opcion2 = Console.ReadLine().ToUpper();

                switch (opcion2)
                {
                    case "A":
                        Console.WriteLine("Datos de gerente:");
                        Gerente gerente = new Gerente();
                        Console.WriteLine("Ingrese ID:");
                        gerente.IdEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre:");
                        gerente.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Puesto:");
                        gerente.Puesto = Console.ReadLine();
                        empleados.Add(gerente);
                        break;
                    case "B":
                        Console.WriteLine("Datos de gerente RRHH:");
                        GerenteRRHH gerenteRRHH1 = new GerenteRRHH();
                        Console.WriteLine("Ingrese ID:");
                        gerenteRRHH1.IdEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre:");
                        gerenteRRHH1.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Puesto:");
                        gerenteRRHH1.Puesto = Console.ReadLine();
                        empleados.Add(gerenteRRHH1);
                        break;
                    case "C":
                        Console.WriteLine("Datos de Desarrollador:");
                        Desarollador desarollador = new Desarollador();
                        Console.WriteLine("Ingrese ID:");
                        desarollador.IdEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre:");
                        desarollador.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Puesto:");
                        desarollador.Puesto = Console.ReadLine();
                        empleados.Add(desarollador);
                        break;
                    case "D":
                        Console.WriteLine("Datos de Consultor Externo:");
                        ConsultorExterno consultorExterno = new ConsultorExterno();
                        Console.WriteLine("Ingrese ID:");
                        consultorExterno.IdEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Nombre:");
                        consultorExterno.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Puesto:");
                        consultorExterno.Puesto = Console.ReadLine();
                        empleados.Add(consultorExterno);
                        break;
                    default:
                        break;
                }

                break;

            case 2:
                ListarEmpleado();
                break;

            default:
                break;
        }

        Console.WriteLine("==============================");
        Console.WriteLine("==============================");

    } while (opcion != 3);

}

MostrarMenu();


Console.Read();