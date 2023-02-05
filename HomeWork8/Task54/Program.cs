/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using static System.Console;
Clear();

WriteLine("Введите размер матрицы через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1]);
PrintMatrix(matrix);
WriteLine();
SortRowsMatrix(matrix);
PrintMatrix(matrix);


void SortRowsMatrix(int[,] inMatrix)
{

    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < inMatrix.GetLength(1); k++)
            {
                if (inMatrix[i, j] < inMatrix[i, k])
                {
                    int temp = inMatrix[i, k];
                    inMatrix[i, k] = inMatrix[i, j];
                    inMatrix[i, j] = temp;
                }
            }


        }

    }
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