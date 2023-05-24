// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumLine(int[,] matrix)
{
    int minrow = 0;
    int minsumrow = 0;
    int sumrow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minrow = minrow + matrix[0,i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i, j];
            if (sumrow < minrow)
            {
                minrow = sumrow;
                minsumrow = i;
            }
            sumrow = 0;
         }
    }
    Console.Write($"{minsumrow + 1} строка");
}

int[,] GetMatrixAndN(int rows, int cols, int min, int max)
{
    int[,] array = new int [rows, cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0;j < cols; j++)
        {
            array[i,j] = new Random().Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
    Console.WriteLine();
    }
}

int m = 6;
int n = 6;

int[,] array = GetMatrixAndN(m, n, 1, 10);
PrintArray(array);
Console.WriteLine();
MinSumLine(array);
