// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 4; N = 8. -> 30
// M = 1; N = 15 -> 120


int Sum(int a, int b)
{
    // Условие выхода
    if (a == b) return a;
    // Рекурсивный вызов метод если a > b
    else if (a > b) return Sum(a - 1, b) + a;
    // Рекурсивный вызов метод если a < b
    else return Sum(a + 1, b) + a;
}

System.Console.WriteLine(Sum(1, 15));
System.Console.WriteLine(Sum(4, 8));

// System.Console.WriteLine(Sum(15, 1));
// System.Console.WriteLine(Sum(8, 4));