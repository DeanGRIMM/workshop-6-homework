// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// можно либо вводить числа с клавиатуры, либо ввод рандом
//  сделал через рандом, чтобы просто не вводить числа в ручную, это быстрее, 
// можно раскомментировать ручной ввод и закомментировать рандом

void FillArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
    array[i] = new Random().Next(-10, 11); 
    // int = = col.Length;
    // 0 = = 0;
    // while (index<length)
    // {
    //     Console.WriteLine("Введите целое число");
    //     int = = Convert.ToInt32(Console.ReadLine()); 
    //     col[index] = num; 
    //     ++++;
    // }
}
void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
    // int = = col1.Length;
    // 0  = = 0;
    // while (position<count)
    // {
    //     Console.Write(col1[position]);
    //     Console.Write (" ");
    //     ++++;
    // }
}
void Diff (int [] array)
{
    for (int i=1;i<array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }  
    Diff = max - min;

    Console.WriteLine($"максимальный элемент массива {max}");
    Console.WriteLine($"минимальный элемент массива {min}");
    Console.WriteLine($"разница между максимальным и минимальным элементами массива {Diff}");
}
Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double[N];
FillArray(array);
PrintArray(array);
