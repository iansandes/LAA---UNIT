using System;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] S1 = new int[] { 1, 5, 4, 2, 3 };
            int[] S2 = new int[] { 9, 1, 4 };

            SumFinders example = new SumFinders();
            Console.WriteLine(example.sumFinderOne(S1, S2, 12));
            Console.WriteLine(example.sumFinderTwo(S1, S2, 12));
            Console.WriteLine(example.sumFinderThree(S1, S2, 12));
            Console.ReadKey();
        }

        
    }
}