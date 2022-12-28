using System.Diagnostics;
namespace Lab03_Search;
class BusquedaLineal
{
    static void Main2(string[] args)
    {
        Stopwatch time = new Stopwatch();

        Console.WriteLine("Algoritmo de busqueda lineal ");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 12, 25, 43, 7 , 10, 9, 14, 8 };

        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = " + A[i] + " ,");
        }
        Console.WriteLine("\nHora de inicio de ejecucion: " + DateTime.Now.ToString("hh:mm:ffff"));
        time.Start();

        Console.WriteLine("Ingrese el numero del arreglo a buscar : ");
        int numBuscar = Convert.ToInt32(Console.ReadLine());

        int posicionEncontrada = BusquedaLinealID(A, A.Length, numBuscar);

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

    static int BusquedaLinealID(int[] A, int n, float clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }

}
