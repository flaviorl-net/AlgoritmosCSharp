namespace Algoritmos
{
    class HeadSort
    {
        public static void DoHeadSort(int[] valores)
        {
            int tamanho = valores.Length;
            int i = 0;

            for (i = tamanho / 2 - 1; i >= 0; i--)
            {
                FixHeap.DoFixHeap(valores, tamanho, i);
            }

            for (i = tamanho - 1; i > 0; i--)
            {
                Swap.DoSwap(valores[i], valores[0]);
                FixHeap.DoFixHeap(valores, i, 0);
            }
        }
    }
}