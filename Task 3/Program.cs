// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = EnterData("Введите количество строк:  ");
int columns = EnterData("Введите количество столбцов:  ");
int[,] matrix = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] result = new int[rows, columns];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArrayRandom(matrix2);
PrintArray(matrix2);
Console.WriteLine();
if (matrix.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result[i, j] += matrix[i, j] * matrix2[i, j];
    }
}
PrintArray(result);