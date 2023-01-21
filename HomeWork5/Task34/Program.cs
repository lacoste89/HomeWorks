/*Напишите программу реализующую методы формирования массива, 
заполненного случайными положительными трёхзначными числами, 
и подсчета количества чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using static System.Console;
Clear();

int[] array = GetArray(10);
int countEven = GEtCountEven(array);
WriteLine($"[{String.Join(", ", array)}] -> {countEven}");

int [] GetArray(int size){
    
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(100, 1000);
    }

    return resultArray;
}

int GEtCountEven(int[] array){
    int result = 0;

    foreach (int i in array)
    {
        if(i % 2 == 0 ) result++;
    }

    return result;
}
