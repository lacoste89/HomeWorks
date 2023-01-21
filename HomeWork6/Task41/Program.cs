/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using static System.Console;
Clear();

Write("Введите любое количество чисел через пробел: ");
string[] str_array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int countOtherZero = GetCountOtherZero(str_array);
WriteLine($"{String.Join(", ", str_array)} -> {countOtherZero}");

int GetCountOtherZero(string[] str_array){
    int result = 0;

    foreach (string s in str_array)
    {
        if(int.Parse(s) > 0) result++;
    }

    return result;
}