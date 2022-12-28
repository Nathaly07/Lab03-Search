using System.Diagnostics;

namespace Lab03_Search;
class BusquedaBinaria
{
    static void Main(string[] args)
    {
        Stopwatch time = new Stopwatch();

        Console.WriteLine("Algoritmo de busqueda binaria: ");
        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 10, 19, -1, 99, 11, 33, 44, 56, 10, 78, 1 };

        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = " + A[i] + " ,");
        }
        Console.WriteLine("\n Arreglo Ordenado:");
        QuickSort(A, 0, A.Length - 1);
        for (int x = 0; x < A.Length; x++)
        {
            Console.Write($"A[{x}] = " + A[x] + " , ");
        }
        Console.WriteLine("\nHora de inicio de ejecucion: " + DateTime.Now.ToString("hh:mm:ffff"));
        time.Start();

        Console.WriteLine("Ingrese el numero del arreglo a buscar : ");
        int numBuscar = Convert.ToInt32(Console.ReadLine());

        int posicionEncontrada = busquedaBinaria(A, A.Length, numBuscar); //El cero tambien cuenta como posicion

        if (posicionEncontrada != -1)
        {
            Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);
        }
        else
        {
            Console.WriteLine("El elemento no ha sido econtrado");
        }
        time.Stop();
        Console.WriteLine("Hora de fin de ejecucion: " + DateTime.Now.ToString("hh:mm:ffff"));
        Console.WriteLine($"Elapsed Time: {time.Elapsed.TotalMilliseconds} ms");

    }

    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            valorCentral = lista[central];
            if (lista[central] == clave)
                return central;
            else if (clave < lista[central])
                alto = central - 1;
            else
                bajo = central + 1;
        }
        return -1;
    }

    static void QuickSort(int[] a, int primero, int ultimo)
    {
        int i, j, central;
        float pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                int tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j);
        if (i < ultimo)
            QuickSort(a, i, ultimo);
    }
}