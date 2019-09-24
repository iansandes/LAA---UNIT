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

            ParteA parteA = new ParteA();

            parteA.inserirProduto(1, 15);
            parteA.inserirProduto(1, 9);
            parteA.inserirProduto(1, 10);
            parteA.inserirProduto(3, 15);
            parteA.ordenarProdutos();

            Console.WriteLine();

            ParteB parteB = new ParteB();
            parteB.inserirProduto(1, 15, "bom demais");
            parteB.inserirProduto(1, 9, "top de linha");
            parteB.inserirProduto(1, 10, "filé");
            parteB.inserirProduto(3, 15, "top dos tops");
            Console.ReadKey();
        }
    }
}
