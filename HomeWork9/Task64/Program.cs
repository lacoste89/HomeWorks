/*Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел 
в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using static System.Console;
Clear();

WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);
PrintNumbers(N, 1);

void PrintNumbers(int finish, int number)
{
    if (finish == number) Write(finish);
    else
    {
        PrintNumbers(finish, number + 1);
        Write($",{number}");
    }
}

WriteLine();