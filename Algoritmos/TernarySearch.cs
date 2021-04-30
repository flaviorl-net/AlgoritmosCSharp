namespace Algoritmos
{
    class TernarySearch
    {
        public static int DoTernarySearch_V1(int[] valores, int procurado)
        {
            int tamanho = valores.Length;
            int min = 0;
            int max = tamanho - 1;
            int fpivot = 0;
            int spivot = 0;

            while (min <= max)
            {
                int nElem = max - min + 1;

                if (nElem % 3 == 0)
                {
                    fpivot = min + (nElem / 3) - 1;
                    spivot = min + (2 * nElem) - 1;
                }
                else
                {
                    fpivot = min + (nElem / 3);
                    spivot = min + (2 * nElem);
                }

                if (valores[fpivot] == procurado)
                {
                    return fpivot;
                }
                else if (valores[fpivot] > procurado)
                {
                    max = fpivot - 1;
                }
                else if (valores[spivot] == procurado)
                {
                    return spivot;
                }
                else if (valores[spivot] > procurado)
                {
                    min = fpivot + 1;
                    max = spivot - 1;
                }
                else
                {
                    min = spivot + 1;
                }
            }

            return -1;
        }

        public static int DoTernarySearch_V2(int[] valores, int procurado)
        {
            int tamanho = valores.Length;
            int min = 0;
            int max = 0;
            int nElem = 0;
            int fpivot = 0;
            int spivot = 0;

            while (min < max)
            {
                nElem = max - min + 1;
                fpivot = min + (nElem / 3);
                spivot = min + (2 * nElem / 3);

                if (valores[fpivot] > procurado)
                {
                    max = fpivot - 1;
                }
                else if (valores[spivot] > procurado)
                {
                    min = fpivot;
                    max = spivot - 1;
                }
                else
                {
                    min = spivot;
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