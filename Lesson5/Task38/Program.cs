// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

// Метод задающий массив из случайных вещественных чисел
double[] NewArray(int length = 10)
{
    // Объявление вещественночисленного массива
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
        // Заполнение массива вещественными числами
        array[i] = Math.Round(new Random().Next(10, 100) * 0.1, 2);
    return array;
}

// Метод возвращающий разницу между максимальным и минимальным вещественными числами в массиве
double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return Math.Round(max - min, 2);
}

// Вызов метода создающего вещественночисленный массив
double[] arrayA = NewArray();
 
// // Вывод массива, максимального и минимального значений для диагностики 
// Console.WriteLine($"[{String.Join(", ", arrayA)}]");
// Array.Sort(arrayA);
// Console.Write($"{arrayA[arrayA.Length - 1]} - {arrayA[0]} = ");

// Вывод разницы между максимальным и минимальным числами в массиве
Console.Write($"Разница: {Difference(arrayA)}");