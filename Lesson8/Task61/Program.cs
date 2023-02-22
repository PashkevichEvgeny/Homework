// Задача 61:
// Задайте двумерный массив содержащий числа из треугольника Паскаля
// и выведите его
//               1
//             1   1
//           1   2   1
//         1   3   3   1
//       1   4   6   4   1
//     1   5  10   10   5  1
//   1   6  15  20  15   6   1
// 1   7  21  35  35  21   7   1

using static System.Console;

// Метод создающий зубчатый массив и заполняющий его числами из Треугольника Паскаля
int[][] CreatePascalTriangle(int size)
{
    // Количество строк в треугольнике
    int[][] array = new int[size][];
    for (int i = 0; i < size; i++)
    {
        // Создание зубцов в массиве
        array[i] = new int[i + 1];
        // Заполнение массива значениями
        for (int j = 0; j < array[i].Length; j++)
        {
            // Крайние элементы заполняются единицами
            if (j == 0 || j == array[i].Length - 1) array[i][j] = 1;
            // Остальные равны сумме верхних двух соседних элементов
            else array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
        }
    }
    return array;
}

void PrintPascalTriangle(int[][] array)
{
    int size = array.Length;
    // Длина квадрата, в котором рисуем треугольник
    int len = string.Join(" ", array[size - 1]).Length / 2;
    for (int i = 0; i < size; i++)
    {
        // Вычисляем количество пробелов перед текстом (длина нижней строки / 2 - длина текущей / 2)
        int lenRow = len - string.Join(" ", array[i]).Length / 2;
        // Печать пробелов
        for (int j = 0; j < lenRow; j++) Write(" ");
        // Печать символов
        Write(string.Join(" ", array[i]));
        WriteLine();
    }
}
Write("Введите размер треугольника, не > 20: ");
int size = int.Parse(ReadLine()!);
int[][] newTriangle = CreatePascalTriangle(size);
PrintPascalTriangle(newTriangle);
