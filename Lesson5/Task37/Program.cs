// Задача 37:
// Найдите произведение пар чисел в одномерном массиве заданным пользователем.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.Clear();

// Метод создающий из пользовательского ввода чисел целочисленный массив
int[] UserArray()
{
    // Пользовательский ввод
    Console.Write("Введите числа пробел или запятую: ");
    // Разделители строки: пробел и/или запятая
    char[] charSeparators = new char[] { ',', ' ' };
    // Перевод строки в строковый массив с удалением лишних пробелов
    string[] numbers = Console.ReadLine()!.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
    // Конвертация строкового массива в целочисленный массив и его возврат из метода
    return Array.ConvertAll(numbers, int.Parse); ;
}

// Метод складывающий массив пополам
int[] FoldedArray(int[] array)
{
    // Длина складываемого массива
    int len = array.Length;
    // Массив длиною 1 нельзя сложить
    if (len == 1) return array;
    // Длина массива после складывания
    int foldLen = (len % 2 == 0) ? len / 2 : len / 2 + 1;
    // Создание нового массива
    int[] fold = new int[foldLen];
    // Заполнение массива числами полученными в результате сложения
    for (int i = 0; i < foldLen; i++)
    {

        if (len % 2 == 1 && i == foldLen - 1)
        {
            // Запись среднего элемента, когда массив нечетного размера
            fold[i] = array[i];
        }
        else
        {
            // Запись остальных элементов массива
            fold[i] = array[i] * array[len - i - 1];
        }
    }
    // Возврат полученного массива
    return fold;
}

// Вызов метода создающего массив на основе пользовательского ввода
int[] randomArray = UserArray();

// // Вывод массива для самопроверки
// Console.WriteLine($"Массив: [{String.Join(" ", randomArray)}]");

// Вызов метода складывающего массив
int[] foldedRandomArray = FoldedArray(randomArray);
// Вывод сложенного массива
Console.WriteLine($"Сложенный массив: {String.Join(" ", foldedRandomArray)}");
