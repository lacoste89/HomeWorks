/*Напишите программу реализующую методы формирования массива, 
заполненного случайными вещественными числами 
и вычисления разницы между максимальным и минимальным элементов массива.

[3,3 7,1 22,5 2,2 78,2] -> 76
*/

using static System.Console;
Clear();

double[] array = GetArray(5);
double differenceMinMax = GetDifferenceMinMax(array);
WriteLine($"[{String.Join(", ", array)}] -> {differenceMinMax}");

double[] GetArray(int size){
    
    double[] resultArray = new double [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.NextDouble() * 100;
    }

    return resultArray;
}

double GetDifferenceMinMax(double[] array){
    return array.Max() - array.Min();
}
