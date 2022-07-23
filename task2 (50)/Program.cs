/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
    int line;
    int column;
    Console.WriteLine("введите номер строки и столбца");
    while (!int.TryParse(Console.ReadLine(), out line) || !int.TryParse(Console.ReadLine(), out column))
    {
        System.Console.WriteLine("Введите корректное значение:");
    }

    if (line < matrx.GetLength(0) && column < matrx.GetLength(1))
    {
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                if (column == j && line == i)
                {
                    System.Console.WriteLine("на заданной позиции находится число: " + matrx[i, j]);
                }
            }

        }

    }
    else
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
}

int[,] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
CheckMatrix(result);