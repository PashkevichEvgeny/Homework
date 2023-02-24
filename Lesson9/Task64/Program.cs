// Задача 64:
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Метод выводит все натуральные числа в промежутке [N, 1]
string NumbersN(int n)
{
    // Условие выхода из рекурсии
    if (n == 1) return $"{n} ";
    // Рекурсивный случай
    else return  $"{n}, {NumbersN(n - 1)}";
}

// Метод выводит все целые числа в промежутке [N, 1]
string NumbersZ(int n)
{
    // Условие выхода из рекурсии
    if (n == 1) return $"{n} ";
    // Рекурсивный случай для положительных чисел
    else if (n > 0) return  $"{n}, {NumbersZ(n - 1)}";
    // Рекурсивный случай для отрицательных чисел
    else return  $"{n}, {NumbersZ(n + 1)}";
}

System.Console.WriteLine(NumbersN(5));
System.Console.WriteLine(NumbersN(8));

// System.Console.WriteLine(NumbersZ(5));
// System.Console.WriteLine(NumbersZ(-8));
