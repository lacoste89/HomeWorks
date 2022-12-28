/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
using static System.Console;
Clear();

WriteLine("Введи число N:");
int finish = int.Parse(ReadLine()!);
WriteLine();

//-------------------------------Простое решение-------------------------------------------//
WriteLine("Простое решение:");

if (finish < 1){
    WriteLine($"{finish} некорректное число");
}
else{
    int i1 = 1;
    while(i1 < finish){
        Write($"{Math.Pow(i1, 3)}, ");
        i1++;
    }
    WriteLine($"{Math.Pow(finish, 3)}");
}
WriteLine();
//-------------------------------Конец простого решение-------------------------------------//

//-------------------------------Сложное решение-------------------------------------------//
//С выводом таблицы кубов и с возможностью указать отрицательное число.
WriteLine("Сложное решение:");

int start = 1;

int size = Math.Abs(start - finish);

string horizontal_separator = "------";
string line_name = "| n  |";
string line_value = "| n³ |";

int n = start;
int i = 0;
while (i <= size)
{
    double kub = Math.Pow(n, 3);
    
    int count_razryad_kub = kub.ToString().Length;
    int count_razryad_j = n.ToString().Length;
    
    horizontal_separator += "---";
    horizontal_separator += new string('-', count_razryad_kub);;
    
    line_name += $" {n}³";
    line_name += new string(' ', count_razryad_kub - count_razryad_j);
    line_name += "|";
    
    line_value += $" {kub} |";

    if (finish >= start) n++;
    else n--;

    i++;
}

WriteLine(horizontal_separator);
WriteLine(line_name);
WriteLine(horizontal_separator);
WriteLine(line_value);
WriteLine(horizontal_separator);
WriteLine();
//-------------------------------Конец сложного решения---------------------------------------//