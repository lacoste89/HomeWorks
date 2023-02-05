/*Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using static System.Console;
Clear();

Write("Введи M и N для вычяслениия по функции Аккермана чнерез пробел: ");

ulong[] param = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), ulong.Parse);

WriteLine($"A({param[0]},{param[1]}) = {Akkerman(param[0], param[1])}");

ulong Akkerman(ulong numM, ulong numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }
    if (numM > 0 && numN > 0)
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    }
    return 0;
}