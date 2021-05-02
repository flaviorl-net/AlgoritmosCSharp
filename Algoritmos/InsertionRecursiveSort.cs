namespace Algoritmos
{
    class InsertionRecursiveSort
    {
        public static void DoInsertionRecursiveSort(int[] valores, int begin, int end)
        {
            if (begin < end)
            {
                int middle = (begin + end) / 2;
                DoInsertionRecursiveSort(valores, begin, middle);
                DoInsertionRecursiveSort(valores, middle + 1, end);
                InsertionList(valores, begin, middle, end);
            }
        }

        public static void InsertionList(int[] valores, int begin, int middle, int end)
        {
            int left = begin;
            int shift = 0;

            for (int i = middle + 1; i <= end; i++)
            {
                int temp = valores[i];

                for (shift = i; shift > left && valores[shift - 1] > temp; shift--)
                {
                    valores[shift] = valores[shift - 1];
                }

                if (shift != i)
                {
                    valores[shift] = temp;
                }
                left = shift + 1;
            }
        }
    }
}
