/*Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int minRange = -9;
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

int[,] OrderMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 1; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1) - k; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }

        }
    }
    return array;
}
int rows = ReadInt("Введите количество строк => ");
int cols = ReadInt("Введите количество столбцов => ");
int[,] array = GenerateArray2D(rows, cols);
PrintArray2D(array);
int[,] sortarray = OrderMaxMin(array);
PrintArray2D(sortarray);

