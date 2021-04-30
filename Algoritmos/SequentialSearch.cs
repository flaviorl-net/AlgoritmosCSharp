namespace Algoritmos
{
    class SequentialSearch
    {
        public static int DoSequentialSearch(int[] valores, int procurado)
        {
            int tamanho = valores.Length;

            for (int i = 0; i < tamanho; i++)
            {
                if (valores[i] == procurado)
                {
                    return procurado;
                }
            }

            return -1;
        }
    }
}