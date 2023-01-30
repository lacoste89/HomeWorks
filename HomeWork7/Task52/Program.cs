/*
Напишите программу реализующую методы, формирования двумерного массива 
и массива средних арифметических значений каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using static System.Console;
Clear();

int[,] matrix = GetMatrix(5, 4);
PrintMatrix(matrix);
WriteLine(String.Join("; ", GetMeanArray(matrix)));

int [,] GetMatrix(int size1, int size2){
    int[,] result = new int[size1, size2];

    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            result[i,j] = rnd.Next(9);
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

double[] GetMeanArray(int[,]  inMatrix){
    int size = inMatrix.GetLength(1);
    double[] result = new double[size];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {   
        for (int j = 0; j < size; j++)
        {
            result[j] += (double)inMatrix[i,j];
        }
        
    }

    return result;
}