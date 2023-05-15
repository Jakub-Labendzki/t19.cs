static void QuickSortLomuto(int[] T, int lewy, int prawy)
{
    if (lewy < prawy)
    {
        int pivot = T[prawy];
        int i = lewy - 1;
        for (int j = lewy; j < prawy; j++)
        {
            if (T[j] <= pivot)
            {
                i++;
                int temp = T[i];
                T[i] = T[j];
                T[j] = temp;
            }
        }
        int temp2 = T[i + 1];
        T[i + 1] = T[prawy];
        T[prawy] = temp2;

        QuickSortLomuto(T, lewy, i);
        QuickSortLomuto(T, i + 2, prawy);
    }
}
