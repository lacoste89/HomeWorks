/*Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//y = k1 * x + b1
//y = k2 * x + b2
//k1 * x + b1 = k2 * x + b2
//(k1 - k2) * x = b2 - b1
//x = (b2 - b1) / (k1 - k2)
//y = k1 * x + b1 || y = k2 * x + b2

using static System.Console;
Clear();

WriteLine("Программа найдёт точку пересечения двух прямых, заданных уравнениями y = k * x + b");

Write("Введите значения b, k для первой функции через пробел: ");
string[] parametrs1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Equation eq1 = GetEquation(parametrs1);

Write("Введите значения b, k для второй функции через пробел: ");
string[] parametrs2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Equation eq2 = GetEquation(parametrs2);

PrintPointIntersection(eq1, eq2);




Equation GetEquation(string[] parametrs){
    Equation result = new Equation();

    result.b = int.Parse(parametrs[0]);
    result.k = int.Parse(parametrs[1]);

    return result;
}

void PrintPointIntersection(Equation equation1, Equation equation2){
    if(equation1.k == equation2.k){
        if(equation1.b == equation2.b) WriteLine($"b1 = {equation1.b}, k1 = {equation1.k}, b2 = {equation2.b}, k2 = {equation2.k} -> Прямые одинаковы");
        else WriteLine($"b1 = {equation1.b}, k1 = {equation1.k}, b2 = {equation2.b}, k2 = {equation2.k} -> Прямые параллельны");
    }
    else{
        double[] point = GetPointIntersection(equation1, equation2);
        WriteLine($"b1 = {equation1.b}, k1 = {equation1.k}, b2 = {equation2.b}, k2 = {equation2.k} -> ({point[0]}, {point[1]})");
    }
}

double[] GetPointIntersection(Equation equation1, Equation equation2){
    double [] result = new double[2];

    result[0] = (double)(equation2.b - equation1.b) / (equation1.k - equation2.k);
    result[1] = equation1.k * result[0] + equation1.b;

    return result;
}

public struct Equation
{
    public int b;
    public int k;

    public override string ToString()
    {
        return $"({b},{k})";
    }
};
