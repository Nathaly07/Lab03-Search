using System.Diagnostics;
namespace Lab03_Search;
class BusquedaFinal
{
    static void Main1(string[] args)
    {
        int[] arreglo = new int[100];
        int numExitos=0 , numFracasos=0;
        Random r = new Random();
        Random numbuscar = new Random();

        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = r.Next (1,200);
        }

        Console.Write("Arreglo desordenado: \n");
        for (int f = 0; f < arreglo.Length; f++)
        {
            Console.Write( $"A[{(f)}]"+ " : "+arreglo[f] + " , ");
        }
        Console.WriteLine("");

        for (int g = 0; g < 50; g++)
        {
            int posicionEncontrada = BusquedaLinealID(arreglo, arreglo.Length, numbuscar.Next(1,200));
        if (posicionEncontrada != -1)
        {
            Console.WriteLine("- Elemento fue encontrado en la posicion: " + posicionEncontrada);
            numExitos++;
        }
        else
        {
            Console.WriteLine("* El elemento no ha sido econtrado");
            numFracasos++;
        }
        }
        Console.WriteLine("\n-- Numero de exitos de busqueda: " + numExitos);
        Console.WriteLine("** Numero de fracasos de busqueda: " + numFracasos);

        Console.WriteLine("\n-- El porcentaje de Exitos es " + ProcentajeTotal(numExitos) + " % ");
        Console.WriteLine("** El porcentaje de Fracasos es " + ProcentajeTotal(numFracasos) + " % ");

        Console.Write("Arreglo ordenado: \n");
        QuickSort(arreglo,0, arreglo.Length-1);
        for (int x = 0; x < arreglo.Length; x++)
        {
            Console.Write( $"A[{x}] = " + arreglo[x] + " ,");
        }


    }

    static int ProcentajeTotal(int num)
    {
        int total=50;
        int porcentaje= 100;
        int resultado;
        resultado = (num*porcentaje)/total;
        return resultado;
    }

    static int BusquedaLinealID(int[] A, int n, float clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
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