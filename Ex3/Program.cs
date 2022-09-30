Console.WriteLine("Введите количество строк первой матрицы ");
int lines1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы ");
int coloumns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы ");
int lines2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы ");
int coloumns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[lines1, coloumns1];
int[,] matrix2 = new int[lines2, coloumns2];

CreateArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
CreateArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
}
Console.WriteLine();
Console.WriteLine("Результат умножения матриц");
int [,] multiplyarrays = Multiplication(matrix1,matrix2);
PrintArray(multiplyarrays);


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 51);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
    
int [,] Multiplication (int [,] arr1, int [,] arr2)
{
    int [,] multarr = new int [arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k=0; k < arr1.GetLength(1); k++)
            {
                multarr[i,j] += arr1[i,k]*arr2[k,j]; 
            }
        }
    }
    return multarr;
}
