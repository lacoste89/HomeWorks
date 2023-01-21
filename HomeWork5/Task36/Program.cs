/*Напишите программу реализующую методы формирования массива, 
заполненного случайными числами и подсчета суммы элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using static System.Console;
Clear();

int[] array = GetArray(5);
int sum = SumOddIndex(array);
WriteLine($"[{String.Join(", ", array)}] -> {sum}");

int [] GetArray(int size){
    
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(0, 1000);
    }

    return resultArray;
}

int SumOddIndex(int[] array){
    int result = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) result += array[i];
    }

    return result;
}