int line = 4;
int coloumn = 6;
int[,] array = new int[line, coloumn];

CreatArray(array);
PrintArray(array);
Console.WriteLine();
GetMinSum(array);

void CreatArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void GetMinSum(int[,] arr)
{
    int index = 0;
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            min = sum;
        }
        else if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");
}