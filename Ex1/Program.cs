int line = new Random().Next(4, 8);
int coloumn = new Random().Next(4, 8);
int[,] arrayfirst = new int[line, coloumn];

CreatArray(arrayfirst);
PrintArray(arrayfirst);
Console.WriteLine();
Console.WriteLine("Массив с сортировкой в строках от большего в маньшему элементу");
GetSort(arrayfirst);
Console.WriteLine();
PrintArray(arrayfirst);

void CreatArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void GetSort(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int max;
        int k;
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            max = arr[i, j];
            k = j;
            while (k > 0 && arr[i, k - 1] < max)
            {
                int temp = arr[i, k];
                arr[i, k] = arr[i, k - 1];
                arr[i, k - 1] = temp;
                k--;
            }
            arr[i, k] = max;
        }
    }
}

