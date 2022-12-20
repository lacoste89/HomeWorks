/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
using static System.Console;

Clear();

WriteLine("Введи три числа");

int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);

int max = a;

if (max < b) max = b;
if (max < c) max = c;

WriteLine($"max = {max}");
