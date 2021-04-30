namespace Algoritmos
{
    class MinSelect
    {
        public static int DoMinSelect(int[] valores)
        {
            int tamanho = valores.Length;
            if (tamanho == 0)
            {
                return -1;
            }

            int min = valores[0];

            for (int i = 0; i < tamanho; i++)
            {
                if (valores[i] < min)
                {
                    min = valores[i];
                }
            }

            return min;
        }
    }
}