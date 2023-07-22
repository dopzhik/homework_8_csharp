/*Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, i] = 0;
    }
    return array;
}

int[,] SMatrix(int[,] array)
{
    int temp = 1;
    for (int y = 0; y < array.GetLength(0); y++)
    {
        array[0, y] = temp;
        temp++;
    }
    for (int x = 1; x < array.GetLength(0); x++)
    {
        array[x, array.GetLength(0) - 1] = temp;
        temp++;
    }
    for (int y = array.GetLength(0) - 2; y >= 0; y--)
    {
        array[array.GetLength(0) - 1, y] = temp;
        temp++;
    }
    for (int x = array.GetLength(0) - 2; x > 0; x--)
    {
        array[x, 0] = temp;
        temp++;
    }
    int i = 1;
    int j = 1;
    while (temp < (array.GetLength(0) * array.GetLength(1)))
    {
        while (array[i, j + 1] == 0)
        {
            array[i, j] = temp;
            temp++;
            j++;
        }
        while (array[i + 1, j] == 0)
        {
            array[i, j] = temp;
            temp++;
            i++;
        }
        while (array[i, j - 1] == 0)
        {
            array[i, j] = temp;
            temp++;
            j--;
        }
        while (array[i - 1, j] == 0)
        {
            array[i, j] = temp;
            temp++;
            i--;
        }

    }
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(0); y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = temp;
            }
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

int rows = ReadInt("Введите длину квадрата => ");
int[,] array = GenerateArray2D(rows, rows);
int[,] array2 = SMatrix(array);
PrintArray2D(array2);
