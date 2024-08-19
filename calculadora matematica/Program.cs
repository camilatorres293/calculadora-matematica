using System;

namespace CalculadoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione la operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese su opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    Console.WriteLine("Saliendo de la calculadora.");
                    break;
                }

                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Entrada inválida, por favor ingrese un número válido.");
                    continue;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Entrada inválida, por favor ingrese un número válido.");
                    continue;
                }

                double resultado = 0;
                bool operacionValida = true;

                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre 0.");
                            operacionValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        operacionValida = false;
                        break;
                }

                if (operacionValida)
                {
                    Console.WriteLine($"El resultado es: {resultado}");
                }
            }
        }
    }
}
