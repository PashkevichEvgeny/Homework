// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

/*
// Если ввели 0 - выводим от 1 до 0
if (N == 0)
{
    Console.Write("1 0");
    return;
}
*/

for (int i = 1; i <= Math.Abs(N); i++)
{
    // если ввели положительное число выводим от 1 до N
    if (N > 0) {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
/*
    // если ввели отрицательное число - выводим от 1 до -N 
    else if (i == 1)
    {
        Console.Write($"1 0 {Math.Pow(-i, 3)} ");
    }
    else
    {
        Console.Write($"{Math.Pow(-i, 3)} ");
    }
*/
}
