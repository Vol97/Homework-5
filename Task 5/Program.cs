using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
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

            int absoluteMaxNumberCount = 0;
            int trueCount;
            int neighbourCount;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    neighbourCount = 0;
                    trueCount = 0;
                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            if (i + k >= 0
                                && i + k < array.GetLength(0)
                                && j + l >= 0
                                && j + l < array.GetLength(1)
                                && array[i, j] > array[i + k, j + l]
                                && !(k == 0 && l == 0))
                            {
                                ++trueCount;
                                ++neighbourCount;
                            }
                            if (i + k >= 0
                                && i + k < array.GetLength(0)
                                && j + l >= 0
                                && j + l < array.GetLength(1)
                                && array[i, j] <= array[i + k, j + l]
                                && !(k == 0 && l == 0))
                            {
                                ++neighbourCount;
                            }
                        }
                    }
                    if (trueCount == neighbourCount)
                    {
                        ++absoluteMaxNumberCount;
                    }
                }
            }

            Console.WriteLine($"\n{absoluteMaxNumberCount}");
        }
    }
}
