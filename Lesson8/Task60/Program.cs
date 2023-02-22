// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

using static System.Console;

int[,,] CreateThreeDimensionArray(int a, int b, int c)
{
    // хранилище значений лежащих в массиве
    int[] store = new int[a * b * c];
    // Первое значение для массива
    int value = new Random().Next(10, 100);
    // Создание трехмерного массива
    int count = 0;
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                // Пока значение не уникально, генерируем новое и снова проверяем его
                while (Array.IndexOf(store, value) > -1) value = new Random().Next(10, 100);
                // Записываем значение в массив
                array[i, j, k] = value;
                // Записываем значение в хранилище
                store[count] = value;
                count++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
    WriteLine();
}

int[,,] matrix = CreateThreeDimensionArray(2, 2, 2);
PrintArray(matrix);
