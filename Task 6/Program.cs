using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6, 5];
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

            int[,] resArray = new int[5, 6];
            Console.WriteLine();

            for (int i = 0; i < resArray.GetLength(0); i++)
            {
                for (int j = 0; j < resArray.GetLength(1); j++)
                {
                    resArray[i, j] = array[j, i];
                    Console.Write(resArray[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
