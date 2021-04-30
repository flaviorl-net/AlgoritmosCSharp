namespace Algoritmos
{
    class ShellSort
    {
        public static void DoShellSort(int[] valores)
        {
            int tamanho = valores.Length;
            int pos = 0;

            for (int inc = tamanho / 2; inc > 0; inc /= 2)
            {
                for (int i = inc; i < tamanho; i++)
                {
                    int aux = valores[i];

                    for (pos = i; pos >= inc; pos -= inc)
                    {
                        if (aux < valores[pos - inc])
                        {
                            valores[pos] = valores[pos - inc];
                        }
                        else
                        {
                            break;
                        }
                    }

                    valores[pos] = aux;
                }
            }
        }
    }
}