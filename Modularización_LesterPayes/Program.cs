using System;

class Program
{
    static int opcion;

    static int LeerOpcionM()
    {
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Opción inválida. Intente nuevamente.");
        }
        return opcion;
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menú de Opciones:");
        Console.WriteLine("1. Calculadora Básica");
        Console.WriteLine("2. Validación de Contraseña");
        Console.WriteLine("3. Números Primos");
        Console.WriteLine("4. Suma de Números Pares");
        Console.WriteLine("5. Conversión de Temperatura");
        Console.WriteLine("6. Contador de Vocales");
        Console.WriteLine("7. Cálculo de Factorial");
        Console.WriteLine("8. Juego de Adivinanza");
        Console.WriteLine("9. Paso por Referencia");
        Console.WriteLine("10. Tabla de Multiplicar");
        Console.WriteLine("0. Salir");
    }

    static double LeerNum()
    {
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        }
        return numero;
    }

    static void Sumar(double num1, double num2)
    {
        Console.WriteLine($"Resultado: {num1 + num2}");
    }

    static void Restar(double num1, double num2)
    {
        Console.WriteLine($"Resultado: {num1 - num2}");
    }

    static void Multiplicar(double num1, double num2)
    {
        Console.WriteLine($"Resultado: {num1 * num2}");
    }

    static void Dividir(double num1, double num2)
    {
        if (num2 != 0)
        {
            Console.WriteLine($"Resultado: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Error: División por cero.");
        }
    }

    static void Calculadora()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = LeerNum();
        Console.Write("Ingrese el segundo número: ");
        double num2 = LeerNum();

        Console.Write("Elija operación (+, -, *, /): ");
        char operacion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (operacion)
        {
            case '+': Sumar(num1, num2); break;
            case '-': Restar(num1, num2); break;
            case '*': Multiplicar(num1, num2); break;
            case '/': Dividir(num1, num2); break;
            default: Console.WriteLine("Operación no válida."); break;
        }
    }

    static void ValidarContraseña()
    {
        string contraseña;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            contraseña = Console.ReadLine();
        } while (contraseña != "1234");
        Console.WriteLine("Acceso concedido.");
    }

    static void NumeroPrimo()
    {
        Console.Write("Ingrese un número: ");
        int num = (int)LeerNum();

        bool esPrimo = num > 1;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break;
            }
        }
        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
    }

    static void SumarPares()
    {
        int suma = 0, num;

        Console.Write("Ingrese un número (0 para terminar): ");
        num = (int)LeerNum();

        while (num != 0)
        {
            if (num % 2 == 0)
            {
                suma += num;
            }
            else
            {
                Console.WriteLine("El número ingresado es impar, no se sumará.");
            }

            Console.Write("Ingrese un número (0 para terminar): ");
            num = (int)LeerNum();
        }
        Console.WriteLine($"Suma de números pares: {suma}");
    }

    static double ConvertirFahrenheitACelsius(double temp)
    {
        return (temp - 32) * 5 / 9;
    }

    static double ConvertirCelsiusAFahrenheit(double temp)
    {
        return temp * 9 / 5 + 32;
    }

    static void ConversionTemperatura()
    {
        while (true)
        {
            Console.Write("Ingrese temperatura: ");
            double temp = LeerNum();

            Console.Write("Presione C para convertir de Fahrenheit a Celsius o F para convertir de Celsius a Fahrenheit: ");
            char tipo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (tipo == 'C')
            {
                Console.WriteLine($"Fahrenheit a Celsius: {ConvertirFahrenheitACelsius(temp)} °C");
                break;
            }
            else if (tipo == 'F')
            {
                Console.WriteLine($"Celsius a Fahrenheit: {ConvertirCelsiusAFahrenheit(temp)} °F");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }

    static void ContadorVocales()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();
        int contador = 0;
        foreach (char c in frase)
        {
            if ("aeiou".Contains(c)) contador++;
        }
        Console.WriteLine($"Número de vocales: {contador}");
    }

    static void CalcularFactorial()
    {
        Console.Write("Ingrese un número: ");
        int num = (int)LeerNum();
        long factorial = 1;
        for (int i = 1; i <= num; i++) factorial *= i;
        Console.WriteLine($"Factorial: {factorial}");
    }

    static void JuegoAdivinanza()
    {
        Random rand = new Random();
        int numero = rand.Next(1, 101), intento;
        do
        {
            Console.Write("Adivine el número: ");
            intento = (int)LeerNum();
            Console.WriteLine(intento < numero ? "Muy bajo" : intento > numero ? "Muy alto" : "Correcto!");
        } while (intento != numero);
    }

    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void PasoPorReferencia()
    {
        Console.Write("Ingrese dos números separados por espacio: ");
        string[] nums = Console.ReadLine().Split();
        int a = int.Parse(nums[0]), b = int.Parse(nums[1]);
        Console.WriteLine($"Antes: a={a}, b={b}");
        Intercambiar(ref a, ref b);
        Console.WriteLine($"Después: a={a}, b={b}");
    }

    static void Crear_T_Multiplicar(int num)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    static void Mostrar_T_Multiplicar(int num)
    {
        Console.WriteLine($"Tabla de multiplicar del {num}:");
        Crear_T_Multiplicar(num);
    }

    static void EjecutarTablaMultiplicar()
    {
        Console.Write("Ingrese un número: ");
        int num = (int)LeerNum();
        Mostrar_T_Multiplicar(num);
    }

    static void Main()
    {
        do
        {
            Console.Clear();
            MostrarMenu();
            opcion = LeerOpcionM();

            switch (opcion)
            {
                case 1: Calculadora(); break;
                case 2: ValidarContraseña(); break;
                case 3: NumeroPrimo(); break;
                case 4: SumarPares(); break;
                case 5: ConversionTemperatura(); break;
                case 6: ContadorVocales(); break;
                case 7: CalcularFactorial(); break;
                case 8: JuegoAdivinanza(); break;
                case 9: PasoPorReferencia(); break;
                case 10: EjecutarTablaMultiplicar(); break;
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        } while (opcion != 0);
    }
}