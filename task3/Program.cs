/*Задача 3: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
2 4 | 3 4 2
3 2 | 3 3 1
Результирующая матрица будет:
18 20 8
15 18 7*/

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

bool Pass(int[,] matrixone, int[,] matrixtwo)
{
    if (matrixone.GetLength(0) == matrixtwo.GetLength(1))
    {
        return true;
    }
    System.Console.WriteLine("умножение не возможно, длина строки 1 матрицы не сопвадает с длиной столбца 2 матрицы");
    return false;
}

int[,] MultiMatr(int[,] matrixone, int[,] matrixtwo)
{

    int[,] result = new int[matrixone.GetLength(0), matrixtwo.GetLength(1)];
    for (int i = 0; i < matrixone.GetLength(0); i++)
    {
        for (int j = 0; j < matrixtwo.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrixone.GetLength(0); k++)
            {
                result[i, j] += matrixone[i, k] * matrixtwo[k, j];
            }
        }
    }
    return result;
}


int row1 = ReadInt("Введите количество строк первой матрицы => ");
int col1 = ReadInt("Введите количество столбцов первой матрицы => ");
int row2 = ReadInt("Введите количество строк второй матрицы => ");
int col2 = ReadInt("Введите количество столбцов второй матрицы => ");
int[,] matrixone = GenerateArray2D(row1, col1);
int[,] matrixtwo = GenerateArray2D(row2, col2);
PrintArray2D(matrixone);
PrintArray2D(matrixtwo);
if (Pass(matrixone, matrixtwo))
{
    int[,] resultmatrix = MultiMatr(matrixone, matrixtwo);
    PrintArray2D(resultmatrix);
}


