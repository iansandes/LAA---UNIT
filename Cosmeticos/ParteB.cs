using System;
using System.Collections.Generic;

namespace Cosmeticos
{
    public class ParteB
    {

        private List<int>[] estante = new List<int>[6];


        private List<string>[] descricoes = new List<string>[6];

        private string[] produtos = new string[6] { "vazio", "xampu", "condicionador",
                                             "hidratante", "tintura", "demaquilante" };


       
        public void inserirProduto(int tipo, int valor, string descricao)
        {
            if(estante[tipo] == null)
            {
                estante[tipo] = new List<int>();
                descricoes[tipo] = new List<string>();
            }

           
            estante[tipo].Add(valor);
            descricoes[tipo].Add(descricao);

            int n = estante[tipo].Count;
            for (int i = 1; i < n; ++i)
            {
                string keyDescricao = descricoes[tipo][i];
                int key = estante[tipo][i];
                int j = i - 1;

                while (j >= 0 && estante[tipo][j] > key)
                {
                    estante[tipo][j + 1] = estante[tipo][j];
                    descricoes[tipo][j + 1] = descricoes[tipo][j];
                    j = j - 1;
                }
                estante[tipo][j + 1] = key;
                descricoes[tipo][j + 1] = keyDescricao;
            }
            imprimir(tipo);
        }

        public void imprimir(int tipo)
        {
            
                if (estante[tipo] == null)
                {
                    estante[tipo] = new List<int>();
                    descricoes[tipo] = new List<string>();
                }
                Console.WriteLine(produtos[tipo]);
                for(int j = 0; j < estante[tipo].Count; j++)
                {
                    Console.WriteLine("\nProduto: " + estante[tipo][j]);
                    Console.WriteLine("Descrição: " + descricoes[tipo][j]);
                }
                Console.WriteLine();
            
        }
    }
}