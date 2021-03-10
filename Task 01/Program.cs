using System;

namespace Task_01
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

            int minValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(minValue > array[i,j])
                    {
                        minValue = array[i, j];
                    }
                }
            }

            Console.WriteLine(minValue);
        }
    }
}
