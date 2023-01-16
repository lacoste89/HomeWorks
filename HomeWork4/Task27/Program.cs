/*
Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using static System.Console;
Clear();

int sum_of_digits (int number){
    number = Math.Abs(number);
    int result = 0;
    
    while(number > 0){
        result += number%10;
        number /= 10;
    }

    return result;
}

Write("Введи число: ");
int number = int.Parse(ReadLine()!);

WriteLine(sum_of_digits(number));
