namespace Algoritmos
{
    class BubbleSort
    {
        public static void DoBubbleSort(int[] valores)
        {
            int begin = 1;
            bool swaps = false;
            int tamanho = valores.Length;

            do
            {

                for (int i = tamanho - 1; i >= begin; i--)
                {
                    if (valores[i - 1] > valores[i])
                    {
                        Swap.DoSwap(valores[i], valores[i - 1]);
                        swaps = true;
                    }
                }
            } 
            while (swaps && begin < tamanho);
        }
    }
}