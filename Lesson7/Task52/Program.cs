// Задача 52:
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;

// Метод создающий массив размером M x N из случайных целых чисел в диапазоне range
// метод показывает содержимое массива, если добавить аргумент print = true
int[,] CreateArray(int m, int n, int range, bool print = false)
{
    // Создание массива, размер принимается из аргументов
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // Заполнение массива случайными значениями, range принимается из аргументов
            array[i,j] = new Random().Next(range);
            // Вывод значений в консоль
            if (print) Write($"   {array[i,j]} ");
        }
        if (print) WriteLine();
    } 
    return array;
}


// Метод для вычисления среднего арифметического по столбцам
double[] AverageColumn(int[,] array)
{
    // Вещественный массив длинною в количество столбцов
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Суммирование всех значений из столбца и запись в массив
            average[j] += array[i,j]; 
        }
    }
    // Вычисление среднего арифметического
    for (int i = 0; i < average.Length; i++)
    {
        // Деление суммы всех значений в столбце на количество чисел в этом столбце
        average[i] /= array.GetLength(0); 
    }
    return average;
}

// Создание массива 3х4 и заполнение случайными числами от 1 до 9
int[,] newArray = CreateArray(3, 4, 10);
// Вызов метода, который вычисляет сред арифметическое
double[] mean = AverageColumn(newArray);
WriteLine($"Сред арифм каждого столбца:");
// Вывод сред арифм из массива с выравниванием и обрезкой до 1 знака после запятой
for (int i = 0; i < mean.Length; i++) Write("{0,5}", $"{mean[i]:f1};");
