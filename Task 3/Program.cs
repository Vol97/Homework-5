using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] minValueIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minValueIndex[0], minValueIndex[1]] > array[i, j])
                    {
                        minValueIndex[0] = i;
                        minValueIndex[1] = j;
                    }
                }
            }

            for(int i = 0; i < minValueIndex.Length; i++)
            {
                Console.Write(minValueIndex[i] + " ");
            }
        }
    }
}
