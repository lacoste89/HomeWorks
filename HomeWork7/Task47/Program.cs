/*
Напишите программу реализующую метод, который возвращает массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using static System.Console;
Clear();

Write("Введите размер двумерного массива m×n через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[,] matrix = GetMatrix(int.Parse(str_arg[0]), int.Parse(str_arg[1]));
PrintMatrix(matrix);



double [,] GetMatrix(int size1, int size2){
    double[,] result = new double[size1, size2];

    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            result[i,j] = rnd.NextDouble() * 100;
        }
    }

    return result;
}

void PrintMatrix(double[,] inMatrix){
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
             Write($"{inMatrix[i, j].ToString("N2")} ", 7);
        }
        WriteLine();
    }
    WriteLine();
}