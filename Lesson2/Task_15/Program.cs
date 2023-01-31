// Задача 15:
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine()!);

// Дотошная проверка
// while (numberDay > 7 || numberDay < 1)
// {
//     Console.Write("Введите номер дня недели от 1 до 7 включительно: ");
//     numberDay = int.Parse(Console.ReadLine()!);
// }

if (numberDay > 0 & numberDay < 6 )
{
    Console.WriteLine("нет");
}
if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine("да");
}
