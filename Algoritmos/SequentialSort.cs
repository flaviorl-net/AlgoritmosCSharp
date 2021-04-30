namespace Algoritmos
{
    class SequentialSort
    {
        public static void DoSequentialSort(int[] valores)
        {
            int tamanho = valores.Length;

            for (int i = 0; i < tamanho - 1; i++)
            {
                for (int j = i + 1; j < tamanho; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        Swap.DoSwap(valores[i], valores[j]);
                    }
                }
            }
        }
    }
}