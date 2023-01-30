/*
Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве,
и возвращающий значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1;7 -> такого элемента в массиве нет
1;1 -> 9
*/

using static System.Console;
Clear();

int[,] matrix = GetMatrix(11, 17);
PrintMatrix(matrix);

Write("Введите позиции элемента в двумерном массиве через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintElementInMatrix(int.Parse(str_arg[0]), int.Parse(str_arg[1]), matrix);



int [,] GetMatrix(int size1, int size2){
    int[,] result = new int[size1, size2];

    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            result[i,j] = rnd.Next(99);
        }
    }

    return result;
}

void PrintMatrix(int[,] inMatrix){
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
             Write("{0,4}", matrix[i,j]);
        }
        WriteLine();
    }
    WriteLine();
}

void PrintElementInMatrix(int m, int n, int[,] inMatrix){
    if(m >= inMatrix.GetLength(0) || n >= inMatrix.GetLength(1)) {
        WriteLine($"{m};{n} -> такого элемента в массиве нет");
        return;
    }
    WriteLine($"{m};{n} -> {matrix[m,n]}");
}