using System;

namespace SpecialSort
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] randomNumbers1 = { 4, 13, 8, 9, 7, 1, 6 };
            int[] randomNumbers2 = { 16, 23, 7, 11, 3, 14 };
            SpecialSort(randomNumbers1);
            SpecialSort(randomNumbers2);


            Console.ReadLine();

        }
        static void SpecialSort(int[] randomNumbers)
        {
            Array.Sort(randomNumbers);
            Array.Reverse(randomNumbers);
            int[] sortedNumbers = new int[randomNumbers.Length];
            int i, j = 0;
            for (i = 0; i < randomNumbers.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    sortedNumbers[j] = randomNumbers[i];
                    j++;
                }
                else
                {
                    sortedNumbers[randomNumbers.Length - j] = randomNumbers[i];
                }

            }
            for (int k = 0; k < sortedNumbers.Length; k++)
            {
                Console.Write(sortedNumbers[k] + " ");
            }
            Console.WriteLine();
        }
    }

}
