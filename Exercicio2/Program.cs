using System;
public class Exercicio2
{
    static void Main(string[] args)
    {
        int[] array = new int[5];
        int maior = 0;
        Console.WriteLine("Insira 5 números na lista:");
        int counter = 0;
        while (counter < 5)
        {
            array[counter] = int.Parse(Console.ReadLine());
            counter++;
        }
        for (int i = 0; i < array.Length; i++)
        {
            int soma = 0;
            for (int j = i; j < array.Length; j++)
            {
                soma += array[j];

                if (soma > maior)
                {
                    maior = soma;
                }
            }
        }
        Console.WriteLine("A soma da maior subsequência é {0} ", maior);
    }
}