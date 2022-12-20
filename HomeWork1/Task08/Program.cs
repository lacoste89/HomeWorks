/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
using static System.Console;

Clear();

WriteLine("Введи число");

int n = int.Parse(ReadLine()!);

for (int i = 1; i <= n; i++){
    if (i % 2 == 0){
        if (i == n || i+1 == n) WriteLine($"{i}");
        else Write($"{i}, ");
    }
}
