namespace Algoritmos
{
    class MergeSort
    {
        public static void DoMergeSort(int[] valores, int begin, int end)
        {
            if (begin < end)
            {
                int middle = (begin + end) / 2;

                DoMergeSort(valores, begin, middle);
                DoMergeSort(valores, middle + 1, end);

                MergeList.DoMergeList(valores, begin, middle, end);
            }
        }
    }
}