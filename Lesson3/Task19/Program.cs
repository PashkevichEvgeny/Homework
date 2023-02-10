// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Математический способ

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
int copyN = n;
// Проверка на длину
// while (n < 10000 || n > 99999)
// {
//     Write("Введите число из состоящее из пяти цифр: ");
//     n = int.Parse(Console.ReadLine()!);
// }

if (n / 10000     == n % 10 &&
    n / 1000 % 10 == n % 100 / 10)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
    
int revers = 0;
while (n > 0)
{
    revers = (revers + n % 10) * 10;
    n /= 10;
}
revers /= 10;
if (revers == copyN)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("No It's not palindrome");
}
/*
// Строковый способ
Console.Write("Введите пятизначное число: ");
// Принимаем строку и обрезаем впереди стоящие нули
string digit = Convert.ToString(int.Parse(Console.ReadLine()!));

// Проверка на длину
while (digit.Length != 5)
{
    Console.Write("Введите число из состоящее из пяти цифр: ");
    digit = Convert.ToString(int.Parse(Console.ReadLine()!));
}

string isPalindrome = digit[0] == digit[4] &&
                      digit[1] == digit[3] ? "да" : "нет";
Console.WriteLine(isPalindrome);
*/
