public static class QuickSort
{
    public static void Sortuj(int[] tab, int lewy, int prawy)
    {
        int i = lewy, j = prawy;
        int pivot = tab[(lewy + prawy) / 2];
        int tmp;
        while (i <= j)
        {
            while (tab[i] < pivot)
                i++;
            while (tab[j] > pivot)
                j--;
            if (i <= j)
            {
                tmp = tab[i];
                tab[i] = tab[j];
                tab[j] = tmp;
                i++;
                j--;
            }
        }

        if (lewy < j)
            Sortuj(tab, lewy, j);
        if (i < prawy)
            Sortuj(tab, i, prawy);
    }

    public static void Sortuj(int[] tab)
    {
        Sortuj(tab, 0, tab.Length - 1);
    }
}