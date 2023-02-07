// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;
Clear();

int Exponentiation(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

Write("Введите число A: ");
int numberA = int.Parse(ReadLine()!); 
Write("Введите число B: ");
int numberB = int.Parse(ReadLine()!);

int pow = Exponentiation(numberA, numberB);
WriteLine(pow);
