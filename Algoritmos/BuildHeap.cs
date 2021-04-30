namespace Algoritmos
{
    class BuildHeap
    {
        public static void DoBuildHeap(int[] valores)
        {
            int tamanho = valores.Length;

            for (int i = tamanho / 2; i >= 0; i--)
            {
                new FixHeap().DoFixHeap(valores, tamanho, i);
            }
        }
    }
}