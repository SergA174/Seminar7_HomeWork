﻿// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданный массив:");
int[,] FillArray(int n, int m) // заполнение массива
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
    return array;
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
void PrintArithmetic(int[,] arr)// функция подсчета
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.Write("{0:#.#}\t", (double)sum / arr.GetLength(0));
    }
}
int[,] mas = FillArray(n, m);
PrintArray(mas);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArithmetic(mas);

