using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Введите размеры массива через запятую: ");
        string input = Console.ReadLine();
        string[] sizes = input.Split(',');
        int dimensions = sizes.Length;

        int totalSize = 1;
        int[] dimensionsSizes = new int[dimensions];

        for (int i = 0; i < dimensions; i++)
        {
            dimensionsSizes[i] = int.Parse(sizes[i]);
            totalSize *= dimensionsSizes[i];
        }

        Console.WriteLine($"Количество элементов в массиве: {totalSize}");

        int[] indices = new int[dimensions];

        for (int i = 0; i < totalSize; i++)
        {
            Console.Write("1 ");
            System.Threading.Thread.Sleep(10);
            for (int j = dimensions - 1; j >= 0; j--)
            {
                indices[j]++;

                if (indices[j] < dimensionsSizes[j])
                {
                    break;
                }
                indices[j] = 0;
            }

            if (i % dimensionsSizes[dimensions - 1] == 0)
            {
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
