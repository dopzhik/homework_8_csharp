/*Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int minRange = 0;
    int maxRange = 9;
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");

    }
    System.Console.WriteLine();
}

int[] LowSumRow(int[,] array2D)
{
    int[] sumarray = new int[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        sumarray[i] = sum;
    }
    return sumarray;
}

int FindMin(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min])
        {
            min = i;
        }
    }
    return min + 1;
}

int rows = ReadInt("Введите количество строк => ");
int cols = ReadInt("Введите количество столбцов => ");
int[,] array = GenerateArray2D(rows, cols);
int[] sumarray = LowSumRow(array);
int minrow = FindMin(sumarray);
PrintArray2D(array);
PrintArray(sumarray);
System.Console.WriteLine($"Строка с наименьшей суммой элементов => {minrow} строка");


