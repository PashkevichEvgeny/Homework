// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
using static System.Console;
Clear();

int SumOfDigits(int number)
{
    int sum = 0, mod;
    while (number > 1)
    {
        mod = number % 10;
        number = number / 10;
        sum += mod;
    }
    return sum + number;
}
Write("Введите число: ");
int num = SumOfDigits(int.Parse(ReadLine()!));
WriteLine(num);
