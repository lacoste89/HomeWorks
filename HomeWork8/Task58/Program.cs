/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


using static System.Console;
Clear();

WriteLine("Введите размер 1й матрицы через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrix = GetMatrix(intParams[0], intParams[1]);

WriteLine("Введите размер 2й матрицы через пробел: ");
int[] intParams1 = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrix1 = GetMatrix(intParams1[0], intParams1[1]);


PrintMatrix(matrix);
WriteLine();

PrintMatrix(matrix1);
WriteLine();

if (matrix.GetLength(1) != matrix1.GetLength(0))
    WriteLine("Эти матрицы нельзя умножить на друг друга!");
else
    PrintMatrix(MultMatrix(matrix, matrix1));


int[,] MultMatrix(int[,] inMatrix1, int[,] inMatrix2)
{

    int[,] resultMutrix = new int[inMatrix1.GetLength(0), inMatrix2.GetLength(1)];
    for (int i = 0; i < resultMutrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMutrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix1.GetLength(1); k++)
                resultMutrix[i, j] += inMatrix1[i, k] * inMatrix2[k, j];
        }
    }

    return resultMutrix;
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