/*Напишите программу, которая реализует рекурсивный метод 
нахождения суммы натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


using static System.Console;
Clear();

WriteLine("Введите два числа, между которыми нужно сложить значениия, через пробел: ");
int[] param = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
WriteLine(SumNum(param[0], param[1]));


int SumNum(int start, int finish)
{
    if (start < finish) return (start == finish ? start : SumNum(start, finish - 1) + finish);
    else return (start == finish ? start : SumNum(start, finish + 1) + finish);
}