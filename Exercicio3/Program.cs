using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5] {{4,10,21,34,42},
                                        {9,17,28,35,58},
                                        {19,20,30,47,59},
                                        {27,39,40,48,60},
                                        {29,43,55,62,70} };

            N2 n2 = new N2();

            // Encontra o valor
            n2.Busca(matriz, 21);

            // Não encontra o valor
            n2.Busca(matriz, 78);


            // Complexidade O(log n)
            Logn logn = new Logn();

            //Encontra o valor
            logn.BuscaMatriz(matriz, 21);

            //Não encontra o valor
            logn.BuscaMatriz(matriz, 78);

            Console.ReadKey();
        }


    }
}
