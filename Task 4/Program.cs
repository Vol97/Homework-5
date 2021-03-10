using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 5];
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

            int[] maxValueIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxValueIndex[0], maxValueIndex[1]] < array[i, j])
                    {
                        maxValueIndex[0] = i;
                        maxValueIndex[1] = j;
                    }
                }
            }

            for (int i = 0; i < maxValueIndex.Length; i++)
            {
                Console.Write(maxValueIndex[i] + " ");
            }
        }
    }
}
