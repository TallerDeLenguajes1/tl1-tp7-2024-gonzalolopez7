using EspacioEmpleado;

Empleado[] empleados = {
    new Empleado("nombre1", "apellido1", new DateTime(2000, 1, 1), 's', new DateTime(2010, 1, 1), 200000, Cargos.Auxiliar),
    new Empleado("nombre2", "apellido2", new DateTime(1995, 1, 1), 'c', new DateTime(2003, 1, 1), 250000, Cargos.Ingeniero),
    new Empleado("nombre3", "apellido3", new DateTime(2005, 1, 1), 's', new DateTime(2020, 1, 1), 300000, Cargos.Especialista)
    };

double montoTotal = 0;

foreach (var empleado in empleados)
{
    montoTotal += empleado.Salario();
}

mostrarMaxProxAJubilarse(empleados);




void mostrarMaxProxAJubilarse(Empleado[] empleados) {

    Empleado empleadoMasProxAJubilarse = empleados[0];
    foreach (var empleado in empleados)
    {
        if (empleado.AñosParaJubilarse() <= empleadoMasProxAJubilarse.AñosParaJubilarse())
        {
            empleadoMasProxAJubilarse = empleado;
        }
    }

    System.Console.WriteLine("empleado mas proximo a jubilarse: ");
    System.Console.WriteLine("edad: " + empleadoMasProxAJubilarse.Edad());
    System.Console.WriteLine("antiguedad: " + empleadoMasProxAJubilarse.Antiguedad());
    System.Console.WriteLine("años para jubilarse: " + empleadoMasProxAJubilarse.AñosParaJubilarse());
    System.Console.WriteLine("salario: " + empleadoMasProxAJubilarse.Salario());
}
