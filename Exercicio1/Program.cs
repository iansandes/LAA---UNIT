using System;

//  b) 37 instruções no pior caso e 13 instruções no melhor caso.
//  c) Ordem O(n^2). Depende da entrada. Ideal para um n pequeno.
public class Exercicio1
{
    static void Main(string[] args)
    {
        int[] lista = new int[5] { 1, 2, 4, 6, 8 };

        Console.WriteLine("Escolha um número dentro da lista a seguir:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        int entrada = int.Parse(Console.ReadLine());
        int indice = 0;
        int index = -1;
        foreach (var item in lista)
        {
            if (item == entrada)
            {
                index = indice;
            }
            indice += 1;
        }
        Console.WriteLine("O índice do número {0} é {1}", entrada, index);
    }
}