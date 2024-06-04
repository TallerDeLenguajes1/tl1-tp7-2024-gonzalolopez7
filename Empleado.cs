
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace EspacioEmpleado;

public class Empleado
{
    
    string nombre;
    string apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    DateTime fechaIngreso;
    double sueldoBasico;
    Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public int Antiguedad() {

        int dias = (int)(DateTime.Now - fechaIngreso).TotalDays;
        int años = 0;
        if (dias > 365)
        {
            while (dias >= 365)
            {
                años++;
                dias -= 365;
            }
        }
        return años;
    }

    public int Edad() {

        int dias = (int)(DateTime.Now - fechaNacimiento).TotalDays;
        int años = 0;
        if (dias > 365)
        {
            while (dias >= 365)
            {
                años++;
                dias -= 365;
            }
        }
        return años;
    }

    public int AñosParaJubilarse() {

        return 65 - this.Edad();
    }

}
