using System;

namespace Exercicio3
{
    public class Logn
    {
        public Logn()
        {
        }
        // Dada uma matriz quadrada e ordenada, saber se i está na matriz. Complexidade O(log n).

        public int resultado;
        public int BuscaBinaria(int[] vetor, int esquerda, int direita, int valor)
        {
            if (direita >= esquerda)
            {
                int indice = (esquerda + ((direita - esquerda) / 2));
                int atual = vetor[indice];
                if (atual == valor)
                {
                    Console.WriteLine("Encontrado o valor para O(logn)");
                    return valor;

                }
                if (atual > valor)
                {
                    return BuscaBinaria(vetor, esquerda, indice - 1, valor);
                }
                else
                {
                    return BuscaBinaria(vetor, indice + 1, direita, valor);
                }
            }
            return -1;
        }

        public void BuscaMatriz(int[,] matriz, int num)
        {
            // Vetores auxiliares para varrer a matriz a partir dos valores desses vetores.
            // O valor da posição i no vetor auxiliar é igual a i.
            int[] aux = new int[matriz.GetLength(0)];
            int[] aux2 = new int[matriz.GetLength(0)];
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                aux[j] = j;
            }
            for (int k = 0; k < matriz.GetLength(0); k++)
            {
                aux[k] = k;
            }

            int x = 0;
            int i = 0;

            // Vetor que armazena os valores da linha n da matriz.
            int[] linha = new int[matriz.GetLength(0)];
            while (i < matriz.GetLength(0))
            {
                linha[x] = matriz[i, x];
                x++;
                if (x == matriz.GetLength(0))
                {
                    //Realização da busca binária na linha n da matriz.
                    resultado = BuscaBinaria(linha, 0, linha.Length - 1, num);
                    if (resultado != -1)
                    {
                        break;
                    }
                    x = 0;
                    i++;
                }
            }
            if (resultado == -1)
            {
                Console.WriteLine("Não encontrado o valor para O(logn)");
            }
        }
    }
}