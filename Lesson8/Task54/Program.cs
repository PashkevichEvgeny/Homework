// Задача 54:
// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:        В итоге получается вот такой массив:
//                 1 4 7 2        7 4 2 1
//                 5 9 2 3        9 5 3 2
//                 8 4 2 4        8 4 4 2

using static System.Console;

// Создание двумерного массива N x M случайными значениями от minValue до maxValue
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

// Метод сортирующий значения в строке массива от большего к меньшему
bool SortRowInArray(int[,] array)
{
    // флаг false, изменений в массиве нет
    bool answer = false;
    if (array.GetLength(1) < 2) return answer;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Пузырьковая сортировка значений в строке 
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - k; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    // флаг true, массив изменен
                    if (answer == false) answer = true;
                    // обмен значениями между ячейками массива
                    (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                }
            }
        }
    }
    // Метод возвращает true, если массив был изменен
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
    WriteLine();
}

int[,] a = CreateArray(3, 4, 1, 10);
WriteLine("Неотсортированный массив");
PrintArray(a);

WriteLine("Отсортированный массив");
if (SortRowInArray(a)) PrintArray(a);
else Write("Массив уже отсортирован");
