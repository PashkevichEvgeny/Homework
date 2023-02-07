//Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 7, 3 -> [1, 2, 5, 7, 19, 2, 7, 3]
// 6, 1, 33, 1, 3, 1, 3, 5 -> [6, 1, 33, 1, 3, 1, 3, 5]
using static System.Console;
Clear();

// метод создает массив длиною 8 элементов по умолчанию
int[] NewArray(int a = 8)
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        // Сгенерировать новое число для массива
        int element = new Random().Next(1, 99);
        // Уменьшить количество двузначных чисел в массиве в 10 раз
        for (int k = 0; k < 10; k++) 
            if (element > 9) 
                element = new Random().Next(1, 99);
        // Записать число в массив
        array[i] = element;
    }
    return array;
}
Write("Массив длиною по умолчанию: ");
WriteLine($"[{string.Join(", ", NewArray())}]");

Write("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Read());
System.Console.WriteLine(number);
Write($"[{string.Join(", ", NewArray(number))}]");

