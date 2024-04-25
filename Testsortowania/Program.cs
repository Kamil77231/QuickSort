using System;
using static QuickSort; 

class Program
{
    static void Main()
    {
        int[] liczby = new int[10];
        Random r = new Random();
        Console.WriteLine("Tablica przed sortowaniem: ");
        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = r.Next(0, 1001);
            Console.Write(liczby[i] + ", ");
        }

        QuickSort.Sortuj(liczby);
        Console.WriteLine("\n\nTablica po sortowaniu: ");
        foreach (int liczba in liczby)
        {
            Console.Write(liczba + ", ");
        }
        Console.ReadKey();
    }
}

