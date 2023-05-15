using System;

public class Program
{
    static void Main(string[] args)
    {
        int[] T = new int[20];
        Random rand = new Random();
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = rand.Next(1, 101);
        }
        Console.WriteLine("Nieposortowana lista: ");
        Console.WriteLine(string.Join(" ", T));
        quicksortHoare(T, 0, T.Length - 1);
        Console.WriteLine("Posortowana lista: ");
        Console.WriteLine(string.Join(" ", T));
    }

    static void quicksortHoare(int[] T, int lewy, int prawy)
    {
        int i = lewy;
        int j = prawy;
        int pivot = T[(lewy + prawy) / 2];

        while (i <= j)
        {
            while (T[i] < pivot)
            {
                i++;
            }
            while (T[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = T[i];
                T[i] = T[j];
                T[j] = temp;
                i++;
                j--;
            }
        }

        if (lewy < j)
        {
            quicksortHoare(T, lewy, j);
        }
        if (prawy > i)
        {
            quicksortHoare(T, i, prawy);
        }
    }
}
