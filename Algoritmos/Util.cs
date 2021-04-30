using System;
using System.Linq;

namespace Algoritmos
{
    class Util
    {
        public static int[] ValoresSemRepeticao(int qtde)
        {
            int[] valores = new int[qtde];
            int gerado = 0;

            for (int i = 0; i < qtde; i++)
            {
                gerado = new Random().Next(qtde * 10);

                if (valores.FirstOrDefault(x => x == gerado) == 0)
                {
                    valores[i] = gerado;
                }
                else
                {
                    i--;
                }
            }

            return valores;
        }

        public static int[] ValoresSemRepeticaoOrdenado(int qtde)
        {
            int[] valores = new int[qtde];
            int gerado = 0;

            for (int i = 0; i < qtde; i++)
            {
                gerado = new Random().Next(qtde * 10);

                if (valores.FirstOrDefault(x => x == gerado) == 0)
                {
                    valores[i] = gerado;
                }
                else
                {
                    i--;
                }
            }

            return valores.OrderBy(x => x).ToArray();
        }
    }
}