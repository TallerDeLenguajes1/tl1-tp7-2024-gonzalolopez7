using EspacioCalculadora;

double termino = 0;
int opcion;
bool b;
Calculadora nuevaCalculadora = new Calculadora();

do
{
    Console.WriteLine("\n-. dato = " + nuevaCalculadora.Resultado);
    Console.WriteLine("1. sumar");
    Console.WriteLine("2. restar");
    Console.WriteLine("3. multiplicar");
    Console.WriteLine("4. dividir");
    Console.WriteLine("5. limpiar");
    Console.WriteLine("6. salir");

    b = int.TryParse(Console.ReadLine(), out opcion);
    if (b && opcion > 0 && opcion < 7)
    {
        
        if (opcion < 5)
        {
            
            do
            {
                
                Console.WriteLine("ingresar numero:");
                b = double.TryParse(Console.ReadLine(), out termino);
                if (!b)
                    Console.WriteLine("numero no valido");

            } while (!b);

        }

        switch (opcion)
        {
            case 1:
                nuevaCalculadora.Sumar(termino);
                break;
            
            case 2:
                nuevaCalculadora.Restar(termino);
                break;
            
            case 3:
                nuevaCalculadora.Multiplicar(termino);
                break;

            case 4:
                nuevaCalculadora.Dividir(termino);
                break;

            case 5:
                nuevaCalculadora.Limpiar();
                break;

            default:
                break;
        }

    } else
    {

        Console.WriteLine("opcion no valida");
    
    }


} while (opcion != 6);