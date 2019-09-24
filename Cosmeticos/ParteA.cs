using System;

namespace Cosmeticos
{
    public class ParteA
    {
        private string[] produtos = new string[6] { "vazio", "xampu", "condicionador",
                                             "hidratante", "tintura", "demaquilante" };
        private int[,] estante = new int[6, 40];

        private int[] qtProdutos = new int[6];

        /* Complexidade assintótica N^2 (n ao quadrado), pois trabalha com laços aninhados  */

        public void inserirProduto(int tipo, int valor)
        {

            estante[tipo, qtProdutos[tipo]] = valor;
            qtProdutos[tipo]++;
        }

        public void ordenarProdutos()
        {
            for (int i = 0; i < estante.GetLength(0); i++)
            {
                int[] vetorOrdenar = new int[40];
                int[] indices = new int[40];
                for (int j = 0; j < estante.GetLength(1); j++)
                {
                    vetorOrdenar[j] = estante[i, j];
                    indices[j] = j;
                }

                insertionSort(vetorOrdenar, indices);
                Console.WriteLine(produtos[i]);
                for(int x = vetorOrdenar.Length - qtProdutos[i]; x < vetorOrdenar.Length; x++)
                {
                    if (qtProdutos[i] == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(indices[x]);
                    }
                }
                Console.WriteLine();
            }

        }

        public void insertionSort(int[] vetor, int[] indices)
        {
            int n = vetor.Length;
            for (int i = 1; i < n; ++i)
            {
                int indexKey = indices[i];
                int key = vetor[i];
                int j = i - 1;

                while (j >= 0 && vetor[j] > key)
                {
                    vetor[j + 1] = vetor[j];
                    indices[j + 1] = indices[j];
                    j = j - 1;
                }
                vetor[j + 1] = key;
                indices[j + 1] = indexKey;
            }
        }  
    }
}