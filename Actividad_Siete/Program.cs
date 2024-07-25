using System.ComponentModel;

static void Menu()
{
    Console.WriteLine("1. Menu");
    Console.WriteLine("2. Ingresar Numeros");
    Console.WriteLine("3. Calcular y mostrar moda");
    Console.WriteLine("4. Calcular y mostrar la mediana");
    Console.WriteLine("5. Calcular y mostrar la desivacion mediana");
    Console.WriteLine("Volver a ingresar los numeros");
}

static List<int> Numeros()
{
    Console.WriteLine("Ingrese el limite de la lista: ");
    int limite = Convert.ToInt32(Console.ReadLine());

    List<int> lista = new List<int>();
    for (int i = 0; i < limite; i++)
    {
        Console.WriteLine("Ingrese los valores: "+ i+1);
        
        int valor = Convert.ToInt32(Console.ReadLine());
        lista.Add(valor);
    }
    return lista;
}

static int CalcularModa(List<int> lista)
{
    lista.Sort();

    // Variables para llevar el conteo de la moda
    int moda = lista[0];
    int maxCuenta = 1;
    int cuentaActual = 1;

    // Recorrer la lista para encontrar la moda con el count
    for (int i = 1; i < lista.Count; i++)
    {
        if (lista[i] == lista[i - 1])
        {
            // Incrementar la cuenta si el número es el mismo que el anterior
            cuentaActual =+1;
        }
        else
        {
            // Resetear la cuenta si el número es diferente
            cuentaActual = 1;
        }

        // Actualizar la moda si encontramos una frecuencia mayor
        if (cuentaActual > maxCuenta)
        {
            maxCuenta = cuentaActual;
            moda = lista[i];
        }
    }

    return moda;
}


static double Calcular_Media (List<int> lista) {
    {
        lista.Sort();
        int n = lista.Count;
        if (n % 2 == 0)
        {
            return (lista[n / 2 - 1] + lista[n / 2 ]) / 2;
        }
        else
        {
            return lista[n / 2];
        }


    }
}

    
