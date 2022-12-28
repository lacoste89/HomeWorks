/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
using static System.Console;
Clear();

WriteLine("Програама, которая показывает является ли число палиндромом");
Write("Введи пятизначное число: ");

int a = int.Parse(ReadLine()!);

//-------------------------------Простое решение-------------------------------------------//
if (9999 < a && a <= 99999)
{
   int fifth_digit = a / 10000;
   int four_digit = a % 10000 / 1000;
   int third_digit = a % 1000 / 100;
   int second_digit = a % 100 / 10;
   int first_digit = a % 10;

   if (fifth_digit == first_digit && four_digit == second_digit)
   {
        WriteLine($"{a} -> да");
   }
   else
   {
         WriteLine($"{a} -> нет");
   }
}
else WriteLine("введенно не пятизначное число");
//-------------------------------Конец простого решение-------------------------------------//

//-------------------------------Сложное решение (можно ввести любое число)-----------------//
int count_digit = a == 0 ? 1 : (int)Math.Log10(Math.Abs(a)) + 1;

bool flag = true;
int i = 0;
while(i <= count_digit / 2)
{
    if (a % (int)Math.Pow(10, (count_digit - i)) / (int)Math.Pow(10, (count_digit - i - 1)) != a % (int)Math.Pow(10, (i + 1)) / (int)Math.Pow(10, i)){
        flag = false;
        break;
    }
    i++;
}

if (flag)
{
    WriteLine($"{a} -> да");
}
else
{
    WriteLine($"{a} -> нет");
}
//-------------------------------Конец сложного решения---------------------------------------//