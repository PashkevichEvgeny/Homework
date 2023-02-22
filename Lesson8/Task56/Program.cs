// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2     ->    14    ->   1 строка
// 5 9 2 3     ->    19
// 8 4 2 4     ->    18
// 5 2 6 7     ->    20
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

int RowSumMin(int[,] array)
{
    // Инициализация суммы чисел в ряду, первоначально равна элементу массива [0,0]
    int sumRow = 0;
    // Объявление переменой: сумма текущего ряда
    int currentRow;
    // Номер строки с минимальной суммой
    int minRow = 0;
    // Вычисление суммы первого ряда массива
    for (int i = 0; i < array.GetLength(1); i++) sumRow += array[0,i];

    // Вычисление сумм остальных рядов
    for (int i = 1; i < array.GetLength(0); i++)
    {
            // Инициализация суммы чисел в текущем ряду, равна элементу массива [i,0]
        currentRow = array[i, 0];
        // Вычисление суммы текущего ряда
        for (int j = 1; j < array.GetLength(1); j++) currentRow += array[i,j];
        // Сравнение сумм рядов для
        if (sumRow > currentRow) 
        {
            sumRow = currentRow;
            minRow = i;
        }
    }
    // Возврат номера строки с минимальной суммой элементов
    return minRow + 1;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            Write("{0, 2} ", array[i, j]);
        }
        WriteLine("сумма {0, 3} строка {1}", sum, (i + 1));
    }
    WriteLine();
}

int[,] newArray = CreateArray(10, 2, 1, 100);
PrintArray(newArray);
WriteLine($"{RowSumMin(newArray)} строка");
