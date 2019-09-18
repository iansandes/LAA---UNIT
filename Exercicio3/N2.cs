using System;

namespace Exercicio3
{
    public class N2
    {
        public N2()
        {
        }

        // Dada uma matriz quadrada e ordenada, saber se i está na matriz. Complexidade O(n^2).
        public void Busca(int[,] matriz, int i)
        {
            int n = matriz.GetLength(0);
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == matriz[k, j])
                    {
                        Console.WriteLine("Encontrado o valor para O(n^2)");
                        return;

                    }
                }
            }
            Console.WriteLine("Não encontrado o valor para O(n^2)");
            return;

        }
    }
}