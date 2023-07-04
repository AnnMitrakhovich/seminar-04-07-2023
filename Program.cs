﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int InputNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()!);
// }
// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }
// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// void ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int sortedSize = j + 1; sortedSize < array.GetLength(1); sortedSize++)
//             {
//                 if (array[i, j] < array[i, sortedSize])
//                 {
//                     int temp = 0;
//                     temp = array[i, j];
//                     array[i, j] = array[i, sortedSize];
//                     array[i, sortedSize] = temp;
//                 }                
//             }
//         }
//     }
// }
// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// ChangeArray(myArray);
// Print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int[] SumRowsOf2DArray(int[,] array) 
// Массив из сумм элементов строк двухмерного массива, где индексы одномерного массива - номера строк двухмерного массива.
{
    int [] sumRows = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        sumRows[i] = sum;
    }
    return sumRows;
}
void PrintArray (int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i] + " ");
    }
}
int FindMaximum (int [] array3)
{
    int max = array3[0];
    int indexMax = 0;
    for (int i = 1; i < array3.Length; i++)
    {
        if (array3 [i] > max) 
        {
            max = array3[i];
            indexMax = i;
        }       
    }
    return indexMax;
}


int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int [] arrayOfSums = SumRowsOf2DArray(myArray);
// для проверки печатаем получившийся массив.
PrintArray(arrayOfSums);
Console.WriteLine();
int rowOfMaxSum = FindMaximum(arrayOfSums);
Console.WriteLine($"Первая максимальная сумма элементов в {rowOfMaxSum + 1} строке.");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }
// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// int[] MinNum(int[,] array)
// {
//     int minN = array[0, 0];
//     int[] index = new int[2];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minN)
//             {
//                 minN = array[i, j];
//                 index[0] = i;
//                 index[1] = j;
//             }
//         }
//     }
//     return index;
// }
// int[,] ChangeArray (int [,] array, int [] index)
// {
//     int [,] ChangedArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
//     int row = 0;
//     int col = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i == index[0]) continue;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == index[1]) continue;
//             ChangedArray[row,col] = array[i,j];
//             col++;            
//         }
//         col = 0;
//         row++;
//     }
//     return ChangedArray;
// }
// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[] minimum = MinNum(myArray);
// int[,] resultArray = ChangeArray(myArray,minimum);
// Print2DArray(resultArray);


// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }
// int[] Dict(int[,] array, int min, int max)
// {
//     int[] result = new int[max - min + 1];
//     // 0   1      2 3 4 5 6 7
//     //min min + 1...        max - частота встречаемости
//     // 0   1      2 3 
//     // -5  -4
//     // 5   6  7

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int index = array[i, j] - min;     // min = -5                       
//             result[index]++;                    // array[i, j] = -4                      
//         }                                       // index = -4 -(-5) = -4 + 5 = 1
//     }
//     return result;
// }
// void Result(int[] dict, int min)
// {
//     for (int i = 0; i < dict.Length; i++)
//     {
//         Console.WriteLine($"Число {i + min} встречается {dict[i]} раз(а)");
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int[] dictionary = Dict(myArray, minValue, maxValue);
// Result(dictionary, minValue);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }
// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// void ChangeRowColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Поменять строки на столбцы нельзя");
//     else
//     {    
//         int temp = 0;    
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//                 // (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
//                 temp = array [j,i];
//                 array[j,i] = array [i,j];
//                 array[i,j] = temp;
//             }
//         }
//     }
// }
// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// ChangeRowColumns(myArray);
// Print2DArray(myArray);

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }
// void ChangeRows(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// ChangeRows(myArray);
// Print2DArray(myArray);


