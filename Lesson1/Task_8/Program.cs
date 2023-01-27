// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Первый вариант While
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int count = 2;
while (count <= N)
{
    if (count + 2 > N)
    {
        Console.WriteLine(count);
    }
    else
    {
        Console.Write($"{count}, ");
    }
    count += 2;
}

// Второй вариант Foreach
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 2; i <= n; i += 2)
// {
//     if (i + 2 > n)
//     {
//         Console.WriteLine(i);
//     }
//     else
//     {
//         Console.Write($"{i}, ");
//     }
// }
