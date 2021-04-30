namespace Algoritmos
{
    class BinarySearch
    {
        public static int DoBinarySearch_V1(int[] valores, int procurado)
        {
            int tamanho = valores.Length;

            int min = 0;
            int max = tamanho - 1;

            while (min <= max)
            {
                int med = (min + max) / 2;

                if (valores[med] == procurado)
                {
                    return med;
                }

                if (valores[med] < procurado)
                {
                    min = med + 1;
                }
                else
                {
                    max = med - 1;
                }
            }

            return -1;
        }

        public int DoBinarySearch_V2(int[] valores, int procurado)
        {
            int tamanho = valores.Length;

            int min = 0;
            int max = tamanho - 1;

            while (min <= max)
            {
                int med = (min + max) / 2;

                if (valores[med] < procurado)
                {
                    min = med + 1;
                }
                else if (valores[med] > procurado)
                {
                    max = med - 1;
                }
                else
                {
                    return med;
                }
            }

            return -1;
        }

        public int DoBinarySearch_V3(int[] valores, int procurado)
        {
            int tamanho = valores.Length;

            int min = 0;
            int max = tamanho - 1;

            while (min < max)
            {
                int med = (min + max) / 2;

                if (valores[med] < procurado)
                {
                    min = med + 1;
                }
                else
                {
                    max = med;
                }
            }

            if (valores[min] == procurado)
            {
                return min;
            }
            else
            {
                return -1;
            }
        }
    }
}
