namespace Algoritmos
{
    class InsertionSort
    {
        public static void DoInsertionSort(int[] valores)
        {
            int tamanho = valores.Length;

            for (int i = 0; i < tamanho; i++)
            {
                int aux = valores[i];
                int pos = 0;

                for (pos = i; pos > 0 && valores[pos - 1] > aux; pos--)
                {
                    valores[pos] = valores[pos - 1];
                }

                if (pos != i)
                {
                    valores[pos] = aux;
                }
            }
        }
    }
}