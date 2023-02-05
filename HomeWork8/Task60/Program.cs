/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using static System.Console;
Clear();

WriteLine("Введите размер трехмерной матрицы через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);


if ((intParams[0] * intParams[1] * intParams[2]) < 91)
{
    int[,,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2]);
    PrintMatrix(matrix);
}
else Write("Нельзя задать неповторяющие двузначные числа");


int[,,] GetMatrix(int rows, int cols, int deep)
{

    int[,,] resultMatrix = new int[rows, cols, deep];
    int[] randArray = RandArray(rows * cols * deep);
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                resultMatrix[i, j, k] = randArray[count];
                count++;
            }
        }
    }
    return resultMatrix;
}


int[] RandArray(int size)
{
    int[] randArray = new int[size];
    Random rnd = new Random();
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        int count = 0;
        while (count != size)
        {
            count = 0;
            temp = rnd.Next(10, 100);
            foreach (int s in randArray)
                count += s != temp ? 1 : 0;
        }
        randArray[i] = temp;
    }
    return randArray;
}


void PrintMatrix(int[,,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(2); k++)
            {
                Write($"{inMatrix[i, j, k], 3} ( {i}, {j}, {k} )");
            }
            WriteLine();
        }
    }
}