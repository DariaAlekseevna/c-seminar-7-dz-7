/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],2} | ");
        }
        System.Console.WriteLine();
    }
}

void CheckMatrix(int[,] matrx)
{
    double sum = 0;
    double n = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrx.GetLength(1); i++)
    {
        for (int j = 0; j < matrx.GetLength(0); j++)
        {
            sum += matrx[j, i];
            n++;
        }
        System.Console.Write(Math.Round(sum/n, 2) + "; ");
        sum = 0;
        n = 0;
    }
}

int[,] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
CheckMatrix(result);