using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Loja teste = new Loja();
            teste.ordenarEstante(1);
            teste.imprimir(1);
            Console.ReadKey();*/


            /*TesteB teste = new TesteB();

            teste.inserirProduto(1, 50);
            teste.inserirProduto(1, 38);
            teste.inserirProduto(1, 40);
            teste.inserirProduto(2, 15);
            teste.inserirProduto(2, 12);
            teste.inserirProduto(2, 18);
            teste.inserirProduto(1, 1);

            teste.ordenarProdutos();*/

            ParteB teste = new ParteB();
            teste.inserirProduto(1, 15, "bom demais");
            teste.inserirProduto(1, 9, "top de linha");
            teste.inserirProduto(1, 10, "filé");
            teste.inserirProduto(3, 15, "top dos tops");
            Console.ReadKey();
        }
    }
}
