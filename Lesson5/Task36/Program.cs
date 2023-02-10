// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12]  -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

// Метод создающий одномерный целочисленный массив заполненный случайными числами
int[] NewArray(int a = 10)
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}

// Метод возвращающий сумму элементов массива, стоящих на нечетных позициях
int SumOfOddPosition(int[] array)
{
    // Для хранения суммы элементов на нечетных позициях
    int sum = 0;
    // В цикле суммируем элементы на нечетных позициях
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

// Вызов метода создающего массив
int[] arrayA = NewArray();

// //Вывод всего массива и нечетных позиций в нем для самопроверки
// for (int i = 0; i < arrayA.Length; i ++) Console.Write("{0, 4}", arrayA[i]);
// Console.WriteLine();
// for (int i = 1; i < arrayA.Length; i += 2) Console.Write("{0, 8}", arrayA[i]);
// Console.WriteLine();

// Вызов метода считающего сумму элементов на нечетных позициях
int sum = SumOfOddPosition(arrayA);
// Вывод этой суммы
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
