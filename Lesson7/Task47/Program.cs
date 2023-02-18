// Задача 47:
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

using static System.Console;

// Метода создающий массив заданного пользователем размера и заполняющий его вещественными числами
double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // Заполнение массива вещественными числами в интервале [-9.9, 9.9] 
            array[i, j] = new Random().Next(-99, 100) * 0.1;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Выравнивание столбцов по левому краю и обрезка чисел до одного знака после запятой
            Write("{0,5}", $"{array[i, j]:f1} ");
        }
        WriteLine();
    }
}


// Вызов метода
double[,] newArray = CreateArray(3, 4);

// Вывод значений из массива
PrintArray(newArray);
