/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using static System.Console;
Clear();

WriteLine("Введите размер матрицычерез пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1]);
PrintMatrix(matrix);
WriteLine();
WriteLine($"Cтрока с наименьшей суммой элементов №: {GetMinSumRow(matrix)}");

int GetMinSumRow(int[,] inMatrix)
{
    int index = 0;
    int[] sumRows = new int[inMatrix.GetLength(0)];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            sumRows[i] += inMatrix[i, j];
        }
    }
    int minSumRows = sumRows[0];
    for (int i = 1; i < sumRows.Length; i++)
    {
        if (minSumRows > sumRows[i])
        {
            minSumRows = sumRows[i];
            index = i;
        };
    }
    return index;
}


int[,] GetMatrix(int rows, int columns)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = rnd.Next(9);
        }
    }
    return resultMatrix;
}


void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j],3} ");
        }
        WriteLine();
    }
}