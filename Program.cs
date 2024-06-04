using EspacioEmpleado;

var nuevoEmpleado = new Empleado("gonzalo", "lopez", new DateTime(2005,6,1), 's', new DateTime(2010, 6, 1), 1200, Cargos.Ingeniero);

Console.WriteLine("antiguedad: " + nuevoEmpleado.Antiguedad());

Console.WriteLine("edad: " + nuevoEmpleado.Edad());

Console.WriteLine("años para jubilarse: " + nuevoEmpleado.AñosParaJubilarse());

Console.WriteLine("salario: " + nuevoEmpleado.Salario());