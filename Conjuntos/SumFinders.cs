using System;

namespace Conjuntos
{
    public class SumFinders
    {
        
        public Boolean sumFinderOne(int[] S1, int[] S2, int x)
        {
            //Uso de duas estruturas de repetição aninhadas = n^2
            for (int i = 0; i < S1.Length; i++)
            {
                for (int j = 0; j < S2.Length; j++)
                {

                    int aux = S1[i] + S2[j];
                    if (aux == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean sumFinderTwo(int[] S1, int[] S2, int x)
        {
            // Uso de algoritmo de ordenação de complexidade O(log N) + algoritmo de complexidade O(N)
            mergeSort(S1, 0, S1.Length - 1);
            mergeSort(S2, 0, S2.Length - 1);

            int i = 0;
            int j = S2.Length - 1;

            while(i < S1.Length && j >= 0)
            {
                if((S1[i] + S2[j]) < x)
                {
                    i++;
                }else if((S1[i] + S2[j]) > x)
                {
                    j--;
                }
                else
                {
                    return true;
                }
            }
            return false;

        }

        public Boolean sumFinderThree(int[] S1, int[] S2, int x)
        {
            // Cada elemento das listas é consultado apenas uma única vez
            int i = 0;
            int j = S2.Length - 1;

            while (i < S1.Length && j >= 0)
            {
                if ((S1[i] + S2[j]) < x)
                {
                    i++;
                }
                else if ((S1[i] + S2[j]) > x)
                {
                    j--;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];


            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            i = 0; 
            j = 0; 
            k = l; 
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
    }
}