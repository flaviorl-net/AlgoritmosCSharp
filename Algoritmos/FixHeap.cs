namespace Algoritmos
{
    class FixHeap
    {
        public static void DoFixHeap(int[] valores, int tamanho, int pos)
        {
            int temp = valores[pos];
            int son = 0;

            for (; pos * 2 + 1 < tamanho; pos = son)
            {
                son = 2 * pos + 1;

                if (son < tamanho - 1 && valores[son] < valores[son + 1])
                {
                    son++;
                }
                if (valores[son] > temp)
                {
                    valores[pos] = valores[son];
                }
                else
                {
                    break;
                }
            }

            valores[pos] = temp;
        }
    }
}