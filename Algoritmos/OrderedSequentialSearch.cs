namespace Algoritmos
{
    class OrderedSequentialSearch
    {
        public static int DoOrderedSequentialSearch(int[] valores, int procurado)
        {
            int tamanho = valores.Length;
            int i = 0;

            for (i = 0; i < tamanho; i++)
            {
                if (valores[i] >= procurado)
                {
                    break;
                }
            }

            if (valores[i] == procurado)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}