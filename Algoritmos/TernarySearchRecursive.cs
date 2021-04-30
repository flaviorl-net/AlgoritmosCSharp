namespace Algoritmos
{
    class TernarySearchRecursive
    {
        public static int DoTernarySearchRecursive(int[] valores, int begin, int end, int procurado)
        {
            if (begin > end)
            {
                return -1;
            }

            int nElem = end - begin + 1;
            int fpivot = 0;
            int spivot = 0;

            if (nElem % 3 == 0)
            {
                fpivot = begin + (nElem / 3) - 1;
                spivot = begin + (2 * nElem / 3) - 1;
            }
            else
            {
                fpivot = begin + (nElem / 3);
                spivot = begin + (2 * nElem / 3);
            }

            if (valores[fpivot] == procurado)
            {
                return fpivot;
            }
            else if (valores[fpivot] > procurado)
            {
                end = fpivot - 1;
            }
            else if (valores[spivot] == procurado)
            {
                return spivot;
            }
            else if (valores[spivot] > procurado)
            {
                begin = fpivot + 1;
                end = spivot - 1;
            }
            else
            {
                begin = spivot + 1;
            }

            return DoTernarySearchRecursive(valores, begin, end, procurado);
        }
    }
}