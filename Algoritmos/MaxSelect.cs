namespace Algoritmos
{
    class MaxSelect
    {
        public static int DoMaxSelect(int[] valores)
        {
            int tamanho = valores.Length;
            if (tamanho == 0)
            {
                return -1;
            }

            int max = valores[0];

            for (int i = 0; i < tamanho; i++)
            {
                if (valores[i] > max)
                {
                    max = valores[i];
                }
            }

            return max;
        }
    }
}