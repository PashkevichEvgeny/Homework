// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

// Математический способ
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 100)
{
    Console.WriteLine("третье цифры нет");
}
else{
while (number > 999)
{
    number = number / 10;
}
int thirdNumber = number % 10;
Console.WriteLine(thirdNumber);
}

// Строковый способ
// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine()!;
// if (stringNumber.Length < 3)
// {
//     Console.WriteLine("третье цифры нет");
//     return;
// }
// char thirdSymbol = stringNumber[2];
// Console.WriteLine(thirdSymbol);
