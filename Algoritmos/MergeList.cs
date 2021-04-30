namespace Algoritmos
{
    class MergeList
    {
        public static void DoMergeList(int[] valores, int begin, int middle, int end)
        {
            int firsthalf = begin;
            int secondhalf = middle + 1;
            int i = 0;
            int[] auxValores = new int[valores.Length];

            while (firsthalf <= middle && secondhalf <= end)
            {
                if (valores[firsthalf] < valores[secondhalf])
                {
                    auxValores[i++] = valores[firsthalf++];
                }
                else
                {
                    auxValores[i++] = valores[secondhalf++];
                }
            }

            while (firsthalf <= middle)
            {
                auxValores[i++] = valores[firsthalf++];
            }

            while (secondhalf <= end)
            {
                auxValores[i++] = valores[secondhalf++];
            }

            for (int pos = 0; pos < i; pos++)
            {
                firsthalf = begin;
                firsthalf++;

                valores[firsthalf] = auxValores[pos];
            }
        }
    }
}
