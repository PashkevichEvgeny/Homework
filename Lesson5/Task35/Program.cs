// Задача 35:
// Задайте одномерный массив из 123 случайных чисел [0, 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

// Метод создающий новый массив заданной длины
// и заполняющий его случайными числами из диапазона [0, 1000]
int[] MakeArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(1000);
    return array;
}

// Метод подсчитывающий количество элементов массива на заданном отрезке
int AmountPointsOnSegment(int[] array, int pointA, int pointB)
{
    int amount = 0;
    // В цикле проверяем каждое число, если оно находится на отрезке
    // увеличиваем счетчик
    foreach (int item in array)
    {
        if (item > pointA - 1 && item < pointB + 1) amount++;
    }
    return amount;
}

// Задаем параметры: Начало и Конец отрезка, Размер массива
int pointA = 10, pointB = 99, len = 123;
// Создаем новый массив заданной длины
int[] randomArray123 = MakeArray(len);

// // Вывод созданного массива для самопроверки
// Console.WriteLine($"[{String.Join(", ", randomArray123)}]");
// // Вывод точек из заданного отрезка массива для самопроверки
// Console.WriteLine($"Точки на отрезке: {String.Join(" ", from num in randomArray123 where num > pointA - 1 && num < pointB + 1 select num)}");

// Подсчет точек на заданном отрезке
int amountOfPoints = AmountPointsOnSegment(randomArray123, pointA, pointB);
// Вывод количества точек на отрезке
Console.WriteLine($"Количество точек на отрезке [{pointA}, {pointB}]: {amountOfPoints}");
