using EspacioDeClases;

double valor, dato;
int option;
string operacion = "";
bool success, successA;

Calculadora NuevaCalculadora = new Calculadora();

do
{
    Console.WriteLine("----------CALCULADORA 1 ----------");
    Console.WriteLine($"--> VALOR DE DATO ACTUAL: {NuevaCalculadora.Resultado} ");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");
    Console.WriteLine("5-Salir");
    success = int.TryParse(Console.ReadLine(), out option);

    if (success && option!=5)
    {
        Console.WriteLine("Ingrese el valor con el que operará:");
        successA = double.TryParse(Console.ReadLine(), out valor);
        if (successA)
        {
            dato = NuevaCalculadora.Resultado;
            switch (option)
            {
                case 1:
                    NuevaCalculadora.Sumar(valor);
                    operacion = "suma";
                    break;
                case 2:
                    NuevaCalculadora.Restar(valor);
                    operacion = "resta";
                    break;
                case 3:
                    NuevaCalculadora.Multiplicar(valor);
                    operacion = "multuplicacion";
                    break;
                case 4:
                    operacion = "division";
                    if (valor != 0)
                    {
                        NuevaCalculadora.Dividir(valor);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                        operacion="";
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo... FIN.");
                    break;
                default:
                    Console.WriteLine("Caso default.");
                    break;
            }
            if(operacion != ""){
                Console.WriteLine($"La {operacion} de {dato} y {valor} es igual a: {NuevaCalculadora.Resultado}");
            }
            Console.WriteLine("¿Desea realizar otro cálculo? Ingrese 5 para salir:");
            int.TryParse(Console.ReadLine(), out option);
            operacion = "";
        }
        else
        {
            Console.WriteLine("No ingreso numeros validos para operar.");
        }
    }
    else
    {
        Console.WriteLine("Opcion ingresada no valida.");
    }
} while (option != 5);
/*
1ro creamos un nuevo archivo .cs 

*/