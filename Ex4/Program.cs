Console.WriteLine("Задаем трехмерный массив");
Console.WriteLine();
Console.WriteLine("Введите размер по Х");
int linex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер по Y");
int liney = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер по Z");
int linez = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = new int[linex, liney, linez];

PrintArray(CreateArray3D(array));

int[,,] CreateArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int k = 0;
            while (k < arr.GetLength(2))
            {
                int number = new Random().Next(10, 99);
                if (FindElement(arr, number))
                {
                    continue;
                }
                arr[i, j, k] = number;
                k++;
            }
        }
    }
    return arr;
}

bool FindElement(int[,,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}