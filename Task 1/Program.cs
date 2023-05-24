// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
//  1 4 7 2 (j)
//   

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
Sort(array);
PrintArray(array);