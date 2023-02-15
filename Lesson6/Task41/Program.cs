// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

int[] InputArray()
{
    Console.Write("Введите элементы массива через пробел и/или запятую: ");
    string[] arrayString = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int len = arrayString.Length;
    int[] arrayInt = new int[len];
    for (int i = 0; i < len; i++)
        arrayInt[i] = int.Parse(arrayString[i].Trim());
    return arrayInt;
}

int ItemMoreZero(int[] array)
{
    int count = 0;
    foreach (int item in array) if (item > 0) count++;
    return count;
}

int[] userArray = InputArray();
Console.WriteLine($"[{String.Join(", ", userArray)}]");
int number = ItemMoreZero(userArray);
Console.WriteLine($"Чисел больше нуля: {number}");
