namespace Algoritmos
{
    class KMinSelect
    {
        public static void DoKMinSelect(int[] valores, int k)
        {
            int tamanho = valores.Length;
            int position = 0;
            int min = 0;

            for (int i = 0; i < k; i++)
            {
                position = i;
                min = valores[i];

                for (int j = i + 1; j < tamanho; j++)
                {
                    if (valores[j] < min)
                    {
                        min = valores[j];
                        position = j;
                    }
                }

                if (i != position)
                {
                    Swap.DoSwap(valores[i], valores[position]);
                }
            }
        }

        public static void DoKMinSelect(int[] valores, int begin, int end, int k)
        {
            int i = begin;
            int j = end;
            int privot = valores[--k];

            if (begin < end)
            {
                do
                {
                    while (valores[i] < privot) i++;
                    while (valores[j] > privot) j--;
                    if (i <= j)
                    {
                        if (i != j)
                        {
                            Swap.DoSwap(valores[i], valores[j]);
                            i++;
                            j--;
                        }
                    }
                } while (i <= j);

                if (j < k)
                {
                    begin = i;
                }
                if (k < i)
                {
                    end = j;
                }

                DoKMinSelect(valores, begin, end, ++k);
            }
        }

        public static void DoKMinSelect(int[] valores, int n, int k)
        {
            int begin = 0;
            int end = n - 1;
            k--;

            while (begin < end)
            {
                int i = begin;
                int j = end;
                int pivot = valores[k];

                do
                {
                    while (valores[i] < pivot) i++;
                    while (valores[j] > pivot) j--;
                    if (i <= j)
                    {
                        if (i != j)
                        {
                            Swap.DoSwap(valores[i], valores[j]);
                            i++;
                            j--;
                        }
                    }
                } while (i <= j);

                if (j < k)
                {
                    begin = i;
                }
                if (k < i)
                {
                    end = j;
                }
            }
        }
    }
}