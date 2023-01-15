﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// можно либо вводить числа с клавиатуры, либо ввод рандом
// сделал через рандом, чтобы просто не вводить числа в ручную, это быстрее, 
// можно раскомментировать ручной ввод и закомментировать рандом
// есть оба варианта

void FillArray(int[] array)
{
    for (int i=0;i<array.Length; i++)
    array[i] = new Random().Next(-10, 11); 

    // int length = array.Length;
    // for (int i=0;i<array.Length; i++)
    // {
    //     Console.WriteLine("Введите целое число");
    //     int num = Convert.ToInt32(Console.ReadLine());        
    //     array[i] = num;
    // }

}
void PrintArray(int[] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
    
    // int count = array.Length;
    // int position = 0;
    // while (position<count)
    // {
    //     Console.Write(array[position]);
    //     Console.Write(" ");
    //     position++;
    // }

}
void Greater (int[] array)
{
    int greater = 0;
    for (int i=0;i<array.Length; i++)
    {
        if (array[i]>0) greater+=1;
    }  
    Console.WriteLine($"чисел больше нуля {greater}");
}
Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
PrintArray(array);
Greater(array);