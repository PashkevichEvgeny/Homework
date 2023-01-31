// Задача 10:
// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int secondNumber;

// Дотошная проверка
// while (number > 999 || number < 100)
// {
//     Console.Write("Введите трехзначное число иначе программа не заработает: ");
//     number = int.Parse(Console.ReadLine()!);
// }

secondNumber = number / 10 % 10;
Console.WriteLine(secondNumber);