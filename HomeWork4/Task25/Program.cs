/*
Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
В задаче не использвать стандартный метод Pow!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using static System.Console;
Clear();

int exponentiation_A_to_B (int A, int B){
    int result = 1;
    for(int i = 0; i < B; i++){
        result *= A;
    }

    return result;
}

Write("Введи число A: ");
int A = int.Parse(ReadLine()!);

Write("Введи число B: ");
int B = int.Parse(ReadLine()!);

WriteLine(exponentiation_A_to_B(A, B));
