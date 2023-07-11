// Задача 54: Задайте двумерный массив. Напишите программу, 
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
// int[] SumRowsOf2DArray(int[,] array) 
// // Массив из сумм элементов строк двухмерного массива, где индексы одномерного массива - номера строк двухмерного массива.
// {
//     int [] sumRows = new int [array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         sumRows[i] = sum;
//     }
//     return sumRows;
// }
// void PrintArray (int[] array2)
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
//         Console.Write(array2[i] + " ");
//     }
// }
// int FindMaximum (int [] array3)
// {
//     int max = array3[0];
//     int indexMax = 0;
//     for (int i = 1; i < array3.Length; i++)
//     {
//         if (array3 [i] > max) 
//         {
//             max = array3[i];
//             indexMax = i;
//         }       
//     }
//     return indexMax;
// }


// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int [] arrayOfSums = SumRowsOf2DArray(myArray);
// // для проверки печатаем получившийся массив.
// PrintArray(arrayOfSums);
// Console.WriteLine();
// int rowOfMaxSum = FindMaximum(arrayOfSums);
// Console.WriteLine($"Первая максимальная сумма элементов в {rowOfMaxSum + 1} строке.");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
// int[,] MultiplicationsOf2DArrays(int[,] array1, int[,] array2)
// Массив из сумм элементов умножения строк одного двухмерного массива на элементы столбцов второго двухмерного массива.
// Умножение возможно только, если количество столбцов первой матрицы равно количеству строк второй матрицы.
// {
//     int[,] multiArray = new int[array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             multiArray[i, j] = 0;
//             for (int x = 0; x < array1.GetLength(1); x++)
//             {
//                 multiArray[i, j] += array1[i, x] * array2[x, j];
//             }
//         }
//     }
//     return multiArray;
// }

// void Check(int[,] array1, int[,] array2, int columns1, int rows2)
// {
//     if (columns1 != rows2) Console.WriteLine("Умножение матриц невозможно.");
//     else
//     {
//         Console.WriteLine("Произведением двух матриц будет: ");
//         int[,] result = MultiplicationsOf2DArrays(array1, array2);
//         Print2DArray(result);
//     }
// }
// int rows1 = InputNum("Введите количество строк для первого массива: ");
// int cols1 = InputNum("Введите количество столбцов для первого массива: ");
// int minValue1 = InputNum("Введите минимальное значение элемента для первого массива: ");
// int maxValue1 = InputNum("Введите максимальное значение элемента для первого массива: ");
// int[,] myArray1 = Create2DArray(rows1, cols1);
// Fill2DArray(myArray1, minValue1, maxValue1);
// Console.WriteLine();
// int rows2 = InputNum("Введите количество строк для второго массива: ");
// int cols2 = InputNum("Введите количество столбцов для второго массива: ");
// int minValue2 = InputNum("Введите минимальное значение элемента для второго массива: ");
// int maxValue2 = InputNum("Введите максимальное значение элемента для второго массива: ");
// int[,] myArray2 = Create2DArray(rows2, cols2);
// Fill2DArray(myArray2, minValue2, maxValue2);
// Print2DArray(myArray1);
// Console.WriteLine();
// Print2DArray(myArray2);
// Console.WriteLine();
// Check(myArray1, myArray2, cols1, rows2);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[] AvalibleDigits()
{
    int[] digits = new int[90];
    digits[0] = 10;
    for (int i = 1; i < 90; i++)
    {
        digits[i] = digits[i - 1] + 1;
    }
    return digits;
}
int [] RandomDigits(int [] array1)
{
    Random rnd = new Random();
    int index = 0;
    int temp = array1[0];
    for (int i = 0; i < array1.Length/2; i++)
    {
        index = rnd.Next(0,90);
        temp = array1[index];
        array1[index] = array1[i];
        array1[i] = temp;
    }
    return array1;
}
void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i] + " ");
    }
}
int[,,] Create3DArray(int x, int y, int z)
{
    return new int[x, y, z];
}
void Fill3DArray(int[,,] array, int[] numbers)
{
    int index = 0;
    if (index < 90)
    {
    for (int x = 0; x < array.GetLength(0); x++)
        for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
            {
               array[x, y, z] = numbers[index];
                   index ++;                
            }
    }
    else Console.WriteLine("Далее числа будут повторяться.");
}
void Print3DArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z]} ({x}, {y}, {z})\t");
            }
        }
    }

    Console.WriteLine();
}

int rows = InputNum("Введите длину: ");
int cols = InputNum("Введите ширину: ");
int z = InputNum("Введите глубину: ");
Console.WriteLine();
int[] numbersArray = AvalibleDigits();
PrintArray(numbersArray);
Console.WriteLine();
int[] newNumberArray = RandomDigits(numbersArray);
PrintArray(newNumberArray);
Console.WriteLine();
int[,,] myArray = Create3DArray(rows, cols, z);
Fill3DArray(myArray, newNumberArray);
Print3DArray(myArray);
Console.WriteLine();

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


