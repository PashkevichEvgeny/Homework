// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
int max = firstNumber;
if (max > secondNumber)
{
    max = firstNumber;
}
if (firstNumber < secondNumber)
{
    max = secondNumber;
}
Console.WriteLine($"max = {max}");

