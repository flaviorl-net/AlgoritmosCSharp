namespace Algoritmos
{
    class QuickSort
    {
        public static void DoQuickSort(int[] valores, int left, int right)
        {
            if (valores.Length > 1)
            {
                int index = Partition(valores, left, right);

                if (left < index -1)
                {
                    DoQuickSort(valores, left, index -1);
                }
                if (index < right)
                {
                    DoQuickSort(valores, index, right);
                }
            }
        }

        public static int Partition(int[] valores, int left, int right)
        {
            int pivot = valores[(right + left) / 2];

            int i = left;
            int j = right;

            while (i <= j)
            {
                while (valores[i] < pivot)
                {
                    i++;
                }
                while (valores[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap.DoSwap(i, j);
                    i++;
                    j--;
                }
            }
            return i;
        }
    }
}
