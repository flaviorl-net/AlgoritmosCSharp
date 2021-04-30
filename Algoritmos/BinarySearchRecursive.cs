namespace Algoritmos
{
    class BinarySearchRecursive
    {
        public static int DoBinarySearchRecursive(int[] valores, int begin, int end, int procurado)
        {
            if (begin > end)
            {
                return -1;
            }

            int med = (begin + end) / 2;

            if (valores[med] == procurado)
            {
                return med;
            }

            if (valores[med] > procurado)
            {
                return DoBinarySearchRecursive(valores, begin, med - 1, procurado);
            }
            else
            {
                return DoBinarySearchRecursive(valores, med + 1, end, procurado);
            }
        }
    }
}