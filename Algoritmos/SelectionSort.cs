namespace Algoritmos
{
    class SelectionSort
    {
        public static void DoSelectionSort(int[] valores)
        {
            int tamanho = valores.Length;

            for (int i = 0; i < tamanho - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < tamanho; j++)
                {
                    if (valores[min] > valores[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap.DoSwap(valores[i], valores[min]);
                }
            }
        }
    }
}