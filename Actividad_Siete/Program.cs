using System;
using System.Collections.Generic;
using System.Linq;

List<int> lista = new List<int>();

while (true)
{
    try
    {
        Console.Clear();
        Menu();
        Console.Write("Seleccione una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Menu();
                break;
            case 2:
                lista = Numeros();
                break;
            case 3:
                if (lista != null && lista.Count > 0)
                {
                    int moda = CalcularModa(lista);
                    Console.WriteLine("la moda es:"+moda);
                }
                else
                {
                    Console.WriteLine("Primero debe ingresar los números.");
                }
                break;
            case 4:
                if (lista != null && lista.Count > 0)
                {
                    double mediana = CalcularMediana(lista);
                    Console.WriteLine("La mediana de la lista es:"+mediana);
                }
                else
                {
                    Console.WriteLine("Primero debe ingresar los números.");
                }
                break;
            case 5:
                if (lista != null && lista.Count > 0)
                {
                    double desviacion = CalcularDesviacion(lista);
                    Console.WriteLine($"La desviación estándar de la lista es: {desviacion}");
                }
                else
                {
                    Console.WriteLine("Primero debe ingresar los números.");
                }
                break;
            default:
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                break;
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error de formato: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Se ha producido un error: {ex.Message}");
    }

    Console.WriteLine("\nPresiona Enter para continuar...");
    Console.ReadLine();
}

static void Menu()
{
    Console.WriteLine("1. Menu");
    Console.WriteLine("2. Ingresar Numeros");
    Console.WriteLine("3. Calcular y mostrar moda");
    Console.WriteLine("4. Calcular y mostrar la mediana");
    Console.WriteLine("5. Calcular y mostrar la desviación estándar");
}

static List<int> Numeros()
{
    try
    {
        Console.Write("Ingrese el límite de la lista: ");
        int limite = Convert.ToInt32(Console.ReadLine());

        List<int> lista = new List<int>();
        for (int i = 0; i < limite; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            lista.Add(valor);
        }
        return lista;
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error de formato: {ex.Message}");
        return new List<int>();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Se ha producido un error: {ex.Message}");
        return new List<int>();
    }
}

static int CalcularModa(List<int> lista)
{
    lista.Sort();

    int moda = lista[0];
    int maxCuenta = 1;
    int cuentaActual = 1;

    for (int i = 1; i < lista.Count; i++)
    {
        if (lista[i] == lista[i - 1])
        {
            cuentaActual++;
        }
        else
        {
            cuentaActual = 1;
        }

        if (cuentaActual > maxCuenta)
        {
            maxCuenta = cuentaActual;
            moda = lista[i];
        }
    }

    return moda;
}

static double CalcularMediana(List<int> lista)
{
    lista.Sort();
    int n = lista.Count;
    if (n % 2 == 0)
    {
        return (lista[n / 2 - 1] + lista[n / 2]) / 2.0;
    }
    else
    {
        return lista[n / 2];
    }
}

static double CalcularDesviacion(List<int> lista)
{
    double promedio = lista.Average();
    double sumaDesviacion = 0;

    foreach (int numero in lista)
    {
        double diferencia = numero - promedio;
        sumaDesviacion += diferencia * diferencia;
    }

    double varianza = sumaDesviacion / lista.Count;
    return Math.Sqrt(varianza);
}

