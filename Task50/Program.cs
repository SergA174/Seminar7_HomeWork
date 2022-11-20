// Задача 50. Напишите программу, которая на вход принимает 
// значение элемента в двумерном массиве, и возвращает 
// позицию этого элемента или дает указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());


int[,] FillArray(int n, int m) // заполнение массива
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
    // return array;
}
void PrintArray(int[,] arr) // функция вывода массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void Object(int[,] arr)// функция перебора массива
{
    Console.WriteLine("Введите значение элемента массива: ");
    int x = Convert.ToInt32(Console.ReadLine());
    foreach (int i in array) 

    Console.Write(i);
    for (int x = 0; x < array.GetLength(0); x++) 
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            Console.Write(array[x, y]);
        }
    }
}
    int[,] x = new int[,];
    int x;
    // bool found = false;
    // Задать первоначальные значения элементов массива nums.
    // for (int i = 0; i < arr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < arr.GetLength(1); j++)
    //         // nums[i, j] = x;
    //     // val = 5;
    //     // Использовать цикл foreach для поиска заданного
    //     // значения в массиве nums.
    //     foreach (int х in nums)
    //     {
    //         if (x == val) found = true;
    //         // break;
    //     }
    //     if (found)
    //         Console.WriteLine("Значение найдено!");
    // }

int[,] mas = FillArray(n, m);

PrintArray(mas);
// Console.WriteLine("Среднее арифметическое каждого столбца:");
Printbject(mas);

