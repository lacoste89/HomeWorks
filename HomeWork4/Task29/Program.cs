/*
Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]
*/

using static System.Console;
Clear();

void print_random_array_size_of_8 (){
    int[] array = new int[8];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length-1) WriteLine(array[i]);
        else Write($"{array[i]}, ");
    }
}

print_random_array_size_of_8();